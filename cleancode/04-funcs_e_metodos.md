# Regras para funções ou métodos

## Pequenas e com apenas um objetivo

Mantenha suas funções ou métodos o menor possível. É mais fácil ter métodos menores e reutilizáveis do que tudo dentro de um método só.

Código

```cs
// Evite
public void RealizarPedido() 
{ 
    // Cadastra o cliente
    // Aplica o desconto
    // Atualiza o estoque
    // Salva o pedido
}

// Utilize
public void SaveCustomer() { ... }
public void ApplyDiscount() { ... }
public void UpdateInventoy() { ... }
public void PlaceOrder() { ... }
```

## Utilize nomes descritivos

A mesma regra dos nomes anteriormente vista aqui se aplica para este cenário. Mantenha nomes concisos, sem caracteres especiais.

Código

```cs
// Evite
// Calcular o que?
public void Calcular() { ... }

// Utilize
// Calcula o ICMS
public void CalcularICMS() { ... }
```

## Opte por poucos parâmetros

Evite exigir muitos parâmetros para construção do objeto, assim como use e abuse dos Optional Parameters do C#.

Código
```cs
// Evite
public void SaveCustomer(string street, string number, string neighborhood, string city, string state, string country, string zipCode) { ... }

// Melhorando
public void SaveCustomer(Address address) { ... }
```

## Cuidado com efeitos colaterais

Evite que uma função altere valores de outra classe sem ser a dela. Isto é chamado de efeito colateral.

Código

```cs
// Evite
public class Order 
{
    public decimal Total { get; set; }
}

var order = new Order();

// Qualquer um fora da classe Order 
// pode atualizar seu total
order.Total = 250; 
```

```cs
// Utilize
public class Order 
{
    public decimal Total { get; private set; }

    public void CalculateTotal() { ... }
}

var order = new Order();

// Total é privado, ninguém de fora consegue 
// modificá-lo, evitando efeitos colaterais
order.Total = 250; // ERRO
```

## Não tome decisões desnecessárias

Não utilize os famosos "flags" para tomar decisões dentro dos métodos, divida-os em vários métodos ou até mesmo outras classes.

Código

```cs
// Evite
public class CustomerRepository 
{
    public void CreateOrUpdate(Customer customer, bool create)
    {
        if(create)
            ...
        else
            ...
    }
}
```

```cs
// Utilize
public class CustomerRepository 
{
    public void Create(Customer customer) { ... }
    public void Update(Customer customer) { ... }
}
```

