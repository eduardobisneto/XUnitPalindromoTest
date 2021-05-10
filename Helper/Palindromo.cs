using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Helper
{
    public class Palindromo
    {
        public bool IsPalindromo(string valor)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            var cleaned = regex.Replace(valor.ToLower(), "");
            var reversed = new string(cleaned.Reverse().ToArray());
            return (cleaned.Equals(reversed));
        }
    }

}
