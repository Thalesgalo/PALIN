using System.Numerics;

namespace BliblioPalin
{
    public static class Calculo
    {
        public static bool VerficaPalindromo(string numero)
        {
            string numeroStr = numero.ToString();
            int left = 0;
            int right = numeroStr.Length - 1;

            while (left < right)
            {
                if (numeroStr[left] != numeroStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static string EncontraPalindromo(string n)
        {
            BigInteger K = BigInteger.Parse(n);

            while (true)
            {
                K++;
                string StringK = K.ToString();
                if (VerficaPalindromo(StringK))
                {
                    return StringK; 
                }
            }
        }


    }
}