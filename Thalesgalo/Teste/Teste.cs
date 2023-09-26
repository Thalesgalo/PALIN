using BliblioPalin;
using Xunit;
using FluentAssertions;

namespace Teste
{
    public class Teste
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
        [Fact]
        public void TestEncontraProximoPalindromo()
        {
            // Arrange
            string input = "12345"; // Você pode fornecer qualquer número como entrada

            // Act
            string resultado = Calculo.EncontraProximoPalindromo(input);

            // Assert
            Assert.IsTrue(VerificaPalindromo(resultado));
        }

    }
}