using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    public class Button
    {
        public char number;
        public char[] letters;
        public Button()
        {
            this.number = '-';
            this.letters = ['-'];

        }
        public Button(char number, char[] letters)
        {
            this.number = number;
            this.letters = letters;
        }
    }
}
