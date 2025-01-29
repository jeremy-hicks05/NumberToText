using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    public class Phone
    {
        public Button[] buttons = new Button[9];

        private void InitButtons(Button[] buttons)
        {
            for (int i = 0; i < 9; i++)
            {
                this.buttons[i] = new Button();
            }
        }

        public IEnumerable<char> PressButton(int number, int numberOfPresses)
        {
            if (number == 0)
            {
                yield return ' ';
            }
            else if (number == 1)
            {
                //Console.WriteLine("Reset...");
            }
            else
            {
                //Console.WriteLine("Pressing button...");
                while (numberOfPresses > buttons[number - 1].letters.Length)
                {
                    yield return buttons[number - 1].letters.Last();
                    numberOfPresses -= buttons[number - 1].letters.Length;
                }
                yield return buttons[number - 1].letters[numberOfPresses - 1];
            }
        }

        public Phone()
        {
            InitButtons(buttons);

            buttons[0].number = '1';
            buttons[0].letters = ['N'];

            buttons[1].number = '2';
            buttons[1].letters = ['a', 'b', 'c'];

            buttons[2].number = '3';
            buttons[2].letters = ['d', 'e', 'f'];

            buttons[3].number = '4';
            buttons[3].letters = ['g', 'h', 'i'];

            buttons[4].number = '5';
            buttons[4].letters = ['j', 'k', 'l'];

            buttons[5].number = '6';
            buttons[5].letters = ['m', 'n', 'o'];

            buttons[6].number = '7';
            buttons[6].letters = ['p', 'q', 'r', 's'];

            buttons[7].number = '8';
            buttons[7].letters = ['t', 'u', 'v'];

            buttons[8].number = '9';
            buttons[8].letters = ['w', 'x', 'y', 'z'];
        }
    }
}
