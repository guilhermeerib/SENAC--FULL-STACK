namespace imc_xunit;

using System;

public class UnitTest1
{
    [Fact]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 26; //25.61 valor correto
        IMC i = new IMC();
        i.peso = 74.0;
        i.altura = 1.70;
        i.Calcular_IMC();
        Console.WriteLine("imc calculado:" + i.imc);
        Assert.Equal(imc_previsto, i.imc);
    }

    [Theory]
    [InlineData("Abaixo do peso")]
    [InlineData("Peso normal")]
    [InlineData("Sobrepeso")]
    [InlineData("Obesidade Grau I")]
    [InlineData("Obesidade Grau II")]
    [InlineData("Obesidade Grau III")]
    
    public void Teste_Categoria_IMC(String cat)
    {
        IMC i = new IMC();
        i.peso = 74.0;
        i.altura = 1.70;
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal(i.categoria, cat);
    }
}
