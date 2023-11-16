using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    internal class ACipher : ICipher
    {
        public void encode(string word)
        {
            char[] chars = word.ToCharArray();
            foreach (char c in chars)
            {
                if (c == 'я')
                {
                    Console.Write("а");
                }
                else if (c == 'z')
                {
                    Console.Write("a");
                }
                else
                {
                    Console.Write((char)(c + 1));
                }
            }
        }
        public void decode(string word2)
        {
            char[] chars2 = word2.ToCharArray();
            foreach (char c2 in chars2)
            {
                if (c2 == 'а')
                {
                    Console.Write("я");
                }
                else if (c2 == 'a')
                {
                    Console.Write("z");
                }
                else
                {
                    Console.Write((char)(c2 - 1));
                }
            }
        }
    }
}
