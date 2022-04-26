using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
     public static class passwor
    {
        public static string password(int caractere, int majus)
        {
            string[] alphab = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "i", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z","#","@","-","&" };
            var rand = new Random();
            string password = "";
            int i = 0;
            while (i < caractere)
            {
                password = password + alphab[rand.Next(alphab.Length)];
                i++;
            }
            if (majus == 1)
            {
                password = password.ToUpper();
            }
            return password;
        }
    }
}
