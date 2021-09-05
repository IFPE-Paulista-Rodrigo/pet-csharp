# Regras de nomes

## Escolha nomes descritivos

Esolher bons nomes para classes, variáveis e métodos é essencial para um código limpo. Lembre-se que se você precisa explicar seu código, então algo pode ser melhorado nele.

Código

```cs
// Evite
var x = 256;

// Duração do que? Qual a métrica?
int duration = 25;

// Muito mais expressivo
int durationInMinutes = 25;

```


## Faça distinções significantes

Utilize sempre nomes nos quais quem estiver lendo seu código possa diferenciar seu significado de outros possíveis nomes.

Código

```cs
// Evite
var salario = 7500M;

// Tem um significado maior
var salarioEmReais = 7500M;
```

## Utilize nomes pronunciáveis e buscáveis

Evite utilizar nomes difíceis de pronunciar ou inventar nomes e conveções para variáveis, classes e métodos. Lembre-se sempre da linguagem ubíquoa e da importância dela no código.

Código

```cs
// Evite
var strTexto = "Meu texto aqui";

// Evite
public void GenerateBoletoInLote() {}

// Evite
public void Cadastry() {}
```

## Evite uso excessivo de strings

Quem nunca perdeu horas procurando um BUG que era apenas um problema de comparação de string? Evite digitar a mesma string várias vezes, utilize constantes para isto.

Código

```cs
// Evite
if(environment == "PROD")
    ...

// Utilize
const string ENV = "PROD";

if(environment == ENV)
    ...
```

##  Não use prefixo ou caracteres especiais

Não utilize prefixo com o tipo da variável, classe ou método e NUNCA use espaços ou caracteres especiais nestes itens.

Código

```cs
// Evite
public class clsCustomer { ... }

// Evite
string strNome = "André";

// Evite
var situação - "Pendente";
```
