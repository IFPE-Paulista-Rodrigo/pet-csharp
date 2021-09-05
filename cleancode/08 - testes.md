# Testes

## Um assert por teste

Utilize um e apenas um assert por teste. Mais de um assert pode confundir você e comprometer a escrita do seu teste.

```cs
// Evite
[TestMethod]
public void ShouldReturnTrue 
{
    Assert.AreEqual(true);
    Assert.AreEqual(1);
}
```

```cs
// Utilize
[TestMethod]
public void ShouldReturnTrue 
{
    Assert.AreEqual(true);
}
```

## Legível

Trate seus testes como parte fundamental do seu código, não secundária. Os testes tem que ser organizados e bem escritos assim como o resto do seu software.

## Rápido

Um dos objetivos principais de um teste é cobrir uma pequena porção do nosso código. Normalmente estendemos esta ideia para a maior parte do código possível, ocasionando uma ampla gama de testes de unidade.

Dados estes testes, os mesmo são executados antes da publicação das nossas aplicações, garantindo que não enviaremos nada com bugs para produção.

Porém, em cenários mais críticos, o tempo dos deploys (Publicações) é extremamente importante, e se nossos testes demoram muito, podem impactar negativamente nisto.


## Independentes

Os testes não devem depender de entidades externas, nem de outros testes. Neste exemplo, volto a salientar o uso do DI e DIP.

## Repetitível

Devemos ter a possibilidade de repetir o mesmo teste, mas com parâmetros diferentes.

Código

```cs
[TestMethod]
[DataRow("email@valido.com", "email@balta.io")]
public void ShouldValidateEmail(string email)
{
    Assert.IsTrue(new Email(email).IsValid());
}
```

