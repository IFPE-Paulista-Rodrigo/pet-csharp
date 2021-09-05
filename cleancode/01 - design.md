# Regras de design

## Mantenha dados de configuração em alto nível

Algo que toda aplicação tem são suas configurações, como as conhecidas ConnectionStrings. Tente sempre deixar estas configurações ou o parse delas em um nível mais alto possível.

Evite sobrescrever configurações em métodos dentro de Controllers ou algo do tipo. Se possível, mantenha esta passagem no método principal, no início da aplicação e não mexa mais nisto!


Código

Em diversas aplicações que trabalho, crio sempre uma classe Settings no projeto base e depois no Startup das aplicações populo ela com as configurações. Isto garante que não teremos estas configurações sendo escritas em todo lugar e também que não precisaremos do IConfiguration que fica no ASP.NET em projetos que não são Web.

MeuProjeto.Domain

```cs
public Startup(IConfiguration configuration)
{
    Configuration = configuration;
    Settings.ConnectionString = Configuration.GetConnectionString("connectionString");
}
```

MeuProjeto.Api

```cs
public Startup(IConfiguration configuration)
{
    Configuration = configuration;
    Settings.ConnectionString = Configuration.GetConnectionString("connectionString");
}
```

MeuProjeto.Infra

```cs
using(var connection = new SqlConnection(Settings.ConnectionString)) {
    ...
}
```

## Polimorfismo no lugar de IFs

Um IF ou condicional, como o nome diz, traz uma tomada de decisão a nossa aplicação, o que implica no aumento da complexidade da mesma. No geral devemos evitar o uso excessivo destes.

Nestes cenários, opte sempre pelo polimorfismo ao invés de tomar decisão em todo método que cria.


Código

Vamos tomar como base uma classe *Pagamento*, onde temos pagamento via Boleto ou Cartão de Crédito, porém nos pagamentos via Boleto, caso o dia do vencimento seja sábado ou domingo (Final de semana), o mesmo pode ser pago no próximo dia útil.

**IMPORTANTE** Esta regra não está 100% correta ou eficiente, é apenas uma demonstração

```cs
public class Pagamento {
    public bool PodeSerPago() {
        if(tipo == ETipoPagamento.Boleto)
        {
            if(vencimento.Day != IsWeekend())
                return true;
        }

        if(tipo == ETipoPagamento.CartaoCredito)
            ...
    }
}
```

Note que temos duas tomadas de decisão dentro do método *PodeSerPago*, onde a primeira se refere apenas a pagamentos do tipo Boleto. Caso hajam mais formas de pagamento futuramente, como tratariamos este código? Encheriamos de IF?

A solução mais plausível é derivar da classe base Pagamento criando o *PagamentoBoleto* que sobrescreve o método *PodeSerPago*, dando uma nova funcionalidade a ele.


```cs
public class Pagamento {
    public virtual bool PodeSerPago() {
        ...
    }
}

public class PagamentoBoleto : Pagamento {
    public override bool PodeSerPago() {
        if(vencimento.Day != IsWeekend())
            return true;
    }
}
```

## Mult-thread
Sempre que necessário utilize processamento em Threads separadas. Já temos suporte a multi-threads e paralelismo no C# faz um bom tempo e o próprio Async/Await já ajudam nisso.


Código

Sem async/await

```cs
[HttpGet("cursos")]
public IActionResult Index([FromServices] IContentRepository repository)
{
    ViewBag.Courses = repository.GetContents(EContentType.Course);
    return View();
}
```

Com async/await

```cs
[HttpGet("cursos")]
public async Task<IActionResult> Index([FromServices] IContentRepository repository)
{
    ViewBag.Courses = await repository.GetContentsAsync(EContentType.Course);
    return View();
}
```

## Separe os códigos mult-thread

Seguindo o mesmo exemplo acima, é uma boa prática manter o que é assíncrono separado do que é síncrono, para não forçar um método a ser ou não assíncrono por conta de outro trecho de código.


Código

```cs
public async Task<IEnumerable<Model>> GetAsync()
{
    var model = new Model();
    model.Courses = await _context.Courses.ToListAsync();
    model.Tags = _context.Courses.ToList(); // Não async
    
    return model;
}
```

## Utilize Async como sufixo

Se um método é assíncrono, utilize sempre o sufixo async para identificá-lo.

```cs

public async Task<IEnumerable<Model>> GetAsync()

```

## Evite configurações desnecessárias

Evite deixar configurações no sistema só por que alguém ainda não definiu como aquilo deve ser. Isto polui o código e traz uma complexidade desnecessária.

Código 

```cs
public void ConfiguraUsoMySql() 
{
    // ainda não sabemos se vamos ou não suportar MySQL também
    throw new NotImplementedException();
}
```

## Utilize injeção de dependência

Sempre que possível utilize injeção de dependência, ele vai tornar seu código mais limpo e desacoplado.


## Lei de Demeter

A Lei de Demeter (**LoD**) ou princípio do menor conhecimento é um princípio que prega os seguintes pontos.

* Cada unidade deve ter conhecimento limitado sobre outras unidades: apenas unidades próximas se relacionam.
* Cada unidade deve apenas conversar com seus amigos.
* Não fale com estranhos, apenas fale com seus amigos imediatos

Código

```cs
public class Order() 
{ 
    public Discount Discount { get; set; }
}

public class Discount() 
{ 
    public decimal Amount { get; set; }

    public void Apply() { ... }
}
```

Mau exemplo

```cs
public class OrderHandler() 
{
    var order = new Order();
    order.Discount.Apply(); // <-
}
```

Bom exemplo

```cs
public class Order() 
{ 
    public Discount Discount { get; set; }

    public void Place() 
    {
        Discount?.Apply();
    }
}

public class OrderHandler() 
{
    var order = new Order();
    order.Place();
}
```

