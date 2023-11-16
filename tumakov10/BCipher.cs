using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    internal class BCipher : ICipher
    {
        public void encode(string word)
        {
            StringBuilder result = new StringBuilder();
            foreach (char letter in word)
            {
                if (char.IsLetter(letter))
                {
                    char changedLetter = (char)(('я' - char.ToLower(letter)) + 'а');
                    result.Append(changedLetter);
                }
                else
                {
                    result.Append(letter); 
                }
            }
            Console.WriteLine(result.ToString());
        }
        public void decode(string word2) 
        {
            StringBuilder result = new StringBuilder();
            foreach (char letter in word2)
            {
                if (char.IsLetter(letter))
                {
                    char changedLetter = (char)(('а' - char.ToLower(letter)) + 'я');
                    result.Append(changedLetter);
                }
                else
                {
                    result.Append(letter);
                }
            }
            Console.WriteLine(result.ToString());
        }

    }
}
