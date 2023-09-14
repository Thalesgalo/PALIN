using BliblioPalin;
using Xunit;

namespace Teste
{
    public class Teste
    {
        [Fact]
        public void VerificaSeEPalindromo()
        {
            //Arrange
            string k = "101";

            //Act
            var resposta = Calculo.VerficaPalindromo(k);

            //Assert
            resposta.Should().Be(true);
        }
    }
}