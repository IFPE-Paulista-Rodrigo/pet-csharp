# Objetos e estruturas

## Esconda estruturas internas

Este tópico abrange uma discussão extensa. Esconder a estrutura de um objeto, ou seja, privar as propridades relacioadas a dados dele, vai sempre trazer resultados positivos e negativos.

Particularmente, gosto de tornar os *SET* privados, mas não é uma regra do meu código e não aplico em todas as propriedades. Como consequência, sempre precisamos de mais métodos para manipulação destes valores.

Se os dados não fazem sentido para os objetos externos, não há discussão, mantenha-os privados.

Código

```cs
public class NotificationContext
{
    private List<string> _notifications;

    public void Add(string notification) 
    {
        _notifications.Add(notification);
    }

    public bool IsValid() => _notifications.Any();

    public IEnumerable Notifications { get => _notifications.AsEnumerable(); }
}
```

## Opte por estrutura de dados

Estruturas de dados representam a forma como os dados são organizados, podendo ser uma class ou um struct. Normalmente associamos as struct mais a estrutura de dados do que as classes, mas podemos estruturar dados com qualquer uma delas.

A diferença é que ao usar class (OOP) temos recursos como abstração, herança, polimorfismo, dentre outros.

Particularmente acho que a segmentação em objetos de valor é um ponto chave neste item.

Código

```cs
// Usando estruturas
public struct Email 
{
    public Email(string address) 
    { 
        // Permite apenas E-mails hotmail, gmail, yahoo...
    }

    public string Address { get; private set; }
}

public class Customer
{
    public Email Email { get; private set; }
}
```

```cs
// Usando classes
public class Email 
{
    public Email(string address) 
    { 
        // Permite qualquer tipo de E-mail
    }

    public string Address { get; private set; }
}

public class CommonEmail : Email
{
    public Email(string address) 
        : base(address)
    { 
        // Permite apenas E-mails hotmail, gmail, yahoo...
    }        
}

public class Customer
{
    public Email Email { get; private set; }
}
```

Nos dois casos temos estruturas representando um E-mail como objeto de valor, porém no segundo cenário, podemos criar extensões e ter uma maior flexibilidade.


## Evite usar dados e objetos juntos

Este é outro ponto polêmico que muitos interpretam como manter nos objetos apenas propriedades enquanto seus comportamentos ficam em outros objetos.

Particularmente acho que a essência de um objeto é justamente o agrupamento de variáveis e funções (Propriedades e métodos). Neste ponto eu sempre mantenho os comportamentos nas entidades.

Em relação a manter parte com object e parte com struct eu confesso que a maior parte dos meus casos eu uso apenas o object. Pode ser vício ou puro comodismo, mas acho estranho esta mistura.

Talvez uma abordagem que aplique estes conceitos de uma forma legal seja novamente o uso dos value objects.

```cs
// Objeto de valor, representa um endereço, sua estrutura de dados
public class Address
{
    public string ZipCode { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}

// Objeto do cliente... com seus comportamentos
public class Customer
{
    public Address BillingAddress { get; private set; }
    public Address ShippingAddress { get; private set; }

    public void ChangeBillingAddress(Address address) { ... }
    public void ChangeShippingAddress(Address address) { ... }
}
```

## Instanciar poucas variáveis

Evite instanciar muitas variáveis nos objetos e seus métodos. Faz uso maior das propriedades se possível.

Código

```cs
public class ShoppingCart
{
    public decimal Total { get; private set; }

    public decimal CalculateTotal()
    {
        var total = 0; // Desnecessário
        foreach(var item in Items)
            total += item.Price;
    }
}
```

```cs
// Melhorando
public class ShoppingCart
{
    public decimal Total { get; private set; }

    private decimal CalculateTotal()
    {        
        foreach(var item in Items)
            Total += item.Price;
    }
}
```

## Classe base não deve saber sobre suas derivadas

Uma classe não deve saber sobre detalhes dos seus filhos. Nas verdade isto me soa tão estranho que não vejo um cenário onde uma classe pai consiga saber detalhes de seus filhos.

## Mais métodos, menos tomadas de decisão

Já comentamos bastante isto na parte de OOP dos cursos, mas fica aqui o reforço, sempre opte por ter mais métodos, mais sobrecargas do que tomadas de decisão.

Código

```cs
// Evite
public class Order
{
    public void Pay(CreditCard card)
    {
        if(card == null)
            // Pagamento via boleto

        // Pagamento via cartão
    }
}
```

```cs
// Utilize
public class Order
{
    public void Pay()
    {
        // Pagamento via boleto
    }

    public void Pay(CreditCard card)
    {
        // Pagamento via cartão de crédito
    }
}
```

## Evite métodos estáticos

Classes e métodos estáticos são difíceis de gerenciar, além de serem compartilhados entre a aplicação como um todo. Imagina que você tem uma classe estática que tem uma lista de notificações, esta lista seria compartilhada entre todas as requisições (Diversos usuários) em seu sistema.

```cs
// Evite
public static class NotificationContext
{
    public static IList<Notification> Notifications { get; set;}
}
```

```cs
// Utilize
public class NotificationContext
{
    public IList<Notification> Notifications { get; set;}
}
```

