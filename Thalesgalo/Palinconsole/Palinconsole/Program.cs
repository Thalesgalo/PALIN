using BliblioPalin;

namespace Palinconsole
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um numero inteiro para saber o valor do menor palindromo maior que [n]");
            string n = Console.ReadLine();

            string ProximoPalindromo = Calculo.EncontraPalindromo(n);
            Console.WriteLine("O menor palíndromo maior que K é: " + ProximoPalindromo);

            Console.ReadKey(true);
        }
    }
}