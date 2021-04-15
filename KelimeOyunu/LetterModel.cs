using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    public class LetterModel
    {
        public char Letter { get; set; }
        public int Index { get; set; }

        public LetterModel(char letter, int index)
        {
            this.Letter = letter;
            this.Index = index;
        }
    }
}
