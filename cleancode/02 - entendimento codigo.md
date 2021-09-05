# Regras sobre entendimento do código


## Seja consistente

Se você executa algo de uma forma, execute todo o resto desta mesma forma. Seja consistente na forma com que aplica o código. Siga sempre o padrão definido.


```cs
// Codificando em inglês
public class CustomerRepository { ... }

// Agora mudou para "portuglês"
public class ProdutoRepository { ... }

// Agora é português
public class RepositorioUnidadeMedida { ... }
``` 


```cs
// Utilizou sufixo ASYNC no método assíncrono
public async Task<Product> GetAsync() { ... }

// Agora não usou mais =/
public async Task<Course> Get() { ... }
```

## Utilize variáveis concisas

```cs
Opte por variáveis concisas, mesmo que resultem em um nome maior. Elas devem ser auto-explicativas, sem a necessidade de comentários ou informações adicionais.
```

Código

```cs
// Total do que?
decimal total = 0;

// Total do carrinho de compras
decimal shoppingCartTotal = 0; 
```

## Obsessão primitiva

No dia-a-dia tendemos a nos focar apenas em tipos primitivos (Built-in), causando uma obsessão pelos mesmos. Podemos criar e usar objetos de valor (Value Objects) para suprir melhor esta necessidade.

Código

Mau exemplo

```cs
public class Customer 
{
    public string Email { get; set; }

    public Customer 
    {
        // Valida E-mail
    }
}

public class Employee 
{
    public string Email { get; set; }

    public Customer 
    {
        // Valida E-mail novamente
    }
}
```

Bom exemplo

```cs
// Value Object
public class Email 
{
    public string Address { get; set; }

    public Email 
    {
        // Valida E-mail
    }
}

public class Customer 
{
    public Email Email { get; set; }
}

public class Employee 
{
    public Email Email { get; set; }
}
```

## Evite dependências lógicas

Não escreva métodos cujo funcionamento correto dependa de algo contido em sua classe.

Código

Mau exemplo

```cs
public class Student 
{
    public bool IsSubscriber { get; set; }

    public void Xpto() 
    {
        if(IsSubscriber)
            ... // Só executa se for assinante   
    }
}
```

Bom exemplo

```cs
public class Student 
{
    ...
}

public class Subscriber : Student
{
    public void Xpto() 
    {
        ...        
    }
}
```

## Evite condicionais negativas

No C# a negação é dada por um sinal de exclamação (!) que muitas vezes pode ser imperceptível, ocasionando na má leitura do código.

Código

```cs
// Evite
if(!IsSubscriber) { ... }

// Utilize
if(IsSubscriber) { ... }
```


