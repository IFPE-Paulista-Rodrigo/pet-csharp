# Estrutura do código

## Separe conceitos verticalmente

Mantenha uma estrutura de pastas saudável e organizada. Não precisa criar uma pasta para cada arquivo, mas pode haver uma separação por contexto ou feature.

Código

```
* MeuApp
	* MeuApp.Domain
		* MeuApp.Domain.Contexts
			* MeuApp.Domain.Contexts.PaymentContext
			* MeuApp.Domain.Contexts.PaymentContexts.Entities
			* MeuApp.Domain.Contexts.PaymentContexts.ValueObjects
		* MeuApp.Domain.Contexts.PaymentContexts.Enums
MeuApp.Domain.Contexts.AccountContext
			* MeuApp.Domain.Contexts.AccountContext.Entities
			* MeuApp.Domain.Contexts.AccountContext.ValueObjects
			* MeuApp.Domain.Contexts.AccountContext.Enums

```

## Declare variáveis próximas de seu uso

Não crie todas as variáveis juntas, no começo da class ou método, defina-as próximas de onde serão utilizadas.

Código

```cs
// Evite
var total = 0;

public void CreateCustomer() { ... }

public void CreateOrder() { ... }

public void UpdateCustomer() { ... }

public void CalculateTotal() 
{ 
    total = 250; // <- Só é utilizada aqui
}
// Utilize
public void CreateCustomer() { ... }

public void CreateOrder() { ... }

public void UpdateCustomer() { ... }

var total = 0;
public void CalculateTotal() 
{ 
    total = 250;
}
```

## Agrupe funcionalidades similares

Se uma função pertence a um grupo dentro de um objeto, mantenha-as sempre por perto.


Código

```cs
// Evite
public void CreateCustomer() { ... } 

public void CheckInventory() { ... }

public void CreateOrder() { ... }

public void UpdateCustomer() { ... }

public void CalculateTotal() { .. }
// Utilize
public void CreateCustomer() { ... } 
public void UpdateCustomer() { ... }

public void CheckInventory() { ... }
public void CreateOrder() { ... }
public void CalculateTotal() { .. }
```

## Declare funções de cima para baixo

Ordenar as funções também é importante. Além da sua ordem de grandeza, suas assinaturas também devem ter uma boa oganização.

Código

```cs
// Utilize
public void CreateCustomer(string name) { ... } 

public void CreateCustomer(string name, int age) { ... } 

public void CreateCustomer(string name, int age, Address address) { ... } 

public void CreateCustomer(string name, int age, Address address, bool active) { ... } 
```

## Mantenha poucas e curtas linhas

Evite funções com linhas longas ou muitas linhas. Não existe um número correto, mas com certeza quanto mais código em uma função, mais difícil de mantê-la será.

Código

```cs
// Utilize
public void CreateCustomer(string name) 
{ 
    var customer = new Customer(name);
    _repository.Customers.Add(customer);
    _repository.SaveChanges();
} 
```

## Não use alinhamento horizontal

Não há necessidade de alinhar horizontalmente variáveis, constantes ou mesmo propriedades.

Código

```cs
// Evite
private   Long            requestParsingTimeLimit;
protected Request         request;
private   FitNesseContent context;
this.context =            context;
input =                   s.getInputStream()
requestParsingTimeLimit = 900;
```

## Use os espaços em branco corretamente

Utilize espaço em branco para associar ou não itens relacionados. Uma boa IDE já fará este trabalho por você.

Código

```cs
// Utilize
private void meuMetodo(String parametro) {
  variavel++;
  int outraVariavel = algumArray.length();
  total += algumMetodo();
  outraClasse.algumMetodo(variavel, total);
  outroMetodo(total);
}
```

## Não quebre a identação

Este item dispensa comentários. Um código não identado não pode ser enviado para o projeto.

Código

```cs
// Evite
public class MinhaClasse{
var valor=12;
Console.WriteLine(valor);
}
```
