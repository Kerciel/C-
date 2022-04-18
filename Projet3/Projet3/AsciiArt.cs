using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet3
{
     class AsciiArt
    {
        public static bool pendu(int nombre ){

            if (nombre == 6)
            {
                Console.WriteLine(@"
                   +------+
                   |      |   
                          |
                          |
                          |
                          |
                 ==========

                ");

            }
            else if (nombre == 5)
            {
                Console.WriteLine(@"
                   +------+
                   |      |   
                   O      |
                          |
                          |
                          |
                 ==========

                ");
            }
            else if (nombre == 4)
            {
                Console.WriteLine(@"
                   +------+
                   |      |   
                   O      |
                   |      |
                          |
                          |
                 ==========

                ");
            }
            else if (nombre == 3)
            {
                Console.WriteLine(@"
                   +------+
                   |      |   
                   O      |
                   |\     |
                          |
                          |
                 ==========

                ");
            }
            else if (nombre == 2)
            {
                Console.WriteLine(@"
                   +------+
                   |      |   
                   O      |
                  /|\     |
                          |
                          |
                 ==========

                ");
            }
            else
        if (nombre == 1)
            {
                Console.WriteLine(@"
                   +------+
                   |      |   
                   O      |
                  /|\     |
                    \     |
                          |
                 ==========

                ");
            }
            else if (nombre == 0)
            {
                Console.WriteLine(@"
                   +------+
                   |      |   
                   O      |
                  /|\     |
                  / \     |
                          |
                 ==========

                ");
            }
                return true;

        }
        public static bool gagner()
        {
            Console.WriteLine(@"
  _______
 |       |
(|victoir|)
 |       |
  \     /
   `---'
   _|_|_
            ");
            return true;
        }
       
    }
}
