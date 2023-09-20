using BliblioPalin;
using System.Collections.Generic;

namespace Palinconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um numero inteiro para saber o valor do menor palindromo maior que [n]");
            string EntradaDeNumeros = Console.ReadLine();

            string ProximoPalindromo = Calculo.EncontraProximoPalindromo(EntradaDeNumeros);
            Console.WriteLine("O menor palíndromo maior que K é: " + ProximoPalindromo);

            Console.ReadKey(true);
        }
    }
}