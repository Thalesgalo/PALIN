using BliblioPalin;
using Xunit;
using FluentAssertions;

namespace Teste
{
    public static class Teste
    {
        [Fact]
        public static void VerificaSeEPalindromo()
        {
            //Arrange
            string k = "101";

            //Act
            var resposta = Calculo.VerificaPalindromo(k);

            //Assert
            resposta.Should().Be(true);
        }
    }
}