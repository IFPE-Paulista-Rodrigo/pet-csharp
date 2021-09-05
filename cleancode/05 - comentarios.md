# Regras de comentários

## Um código bom é expressivo

Teoricamente, se você precisa comentar uma parte do seu código, é por que algo está errado com ele, ele não está expressivo o suficiente.

## Não seja redundante

Evite comentários que não fazem sentido algum ao contexto ou cenário.

Código

```cs
// Evite

// Função principal do sistema
public void Main() { ... }
```

## Não feche os comentários
Não há necessidade de fechar os comentários.

Código

```cs
// Evite

// Comentário // <- Desnecessário
public void Main() { ... }
```

## Evite códigos comentados

Não deixe sujeira em seu código, ao invés de deixar algo comentado, remova ele. Hoje temos versionadores de código, você pode "voltar no tempo" facilmente.

Código

```cs
// Evite
public void MinhaFuncao() 
{ 
    // string texto = "1234";
    // public void Metodo() {... }
}
```

## Inteção

Um bom uso de comentários é sobre a intenção de um método, classe ou variável (Variável nem tanto).

Código

```cs
// Utilize

// Retorna a lista de produtos inativos
// para o relatório de fechamento mensal
public IList<Product> ObtemProdutosInativos() 
{ 
    ...
}
```

## Esclarecimento

Outro uso interessante para os comentários são esclarecimentos sobre o código.

Código

```cs
// Utilize
public void CancelarPedido() 
{ 
    // Caso o pedido já tenha sido enviado
    // ele não pode mais ser cancelado.
    if(DataEnvio > DateTime.Now)
    {
        AddNotification("O pedido já foi enviado e não pode ser cancelado");
    }
}
```

### Consequências

Podemos utilizar comentários para alertar sobre trechos do código que podem ter consequências mais sérias. Neste caso recomendo o uso de um comentário em XML mais elaborado.

Código

