using System.Numerics;
using System.Collections.Generic;

namespace BliblioPalin
{
    public static class Calculo
    {
        public static bool VerificaPalindromo(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static string EncontraProximoPalindromo(string input)
        {
            BigInteger K = BigInteger.Parse(input);

            while (true)
            {
                K++;
                string strK = K.ToString();
                if (VerificaPalindromo(strK))
                {
                    return strK;
                }
            }
        }
    }
}