using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Indexadores
{
    class Sentence
    {
        string[] words = "The quick brown fox".Split();

        public string this [int wordPos] //Indexador
        {
            get { return words[wordPos];  }
            set { words[wordPos] = value; }
        }

    }
}
