using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    internal interface ICipher
    {
        void encode(string word);
        void decode(string word2);
    }
}
