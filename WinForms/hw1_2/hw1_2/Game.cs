using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1_2
{
    public class Game
    {
        private string caption = "Я угадаю твое число!";
        private int check;
        private int counter = 0;

        public Game(int i)
        {
            this.check = i;

            DialogResult result;
            do
            {
                DialogResult ans1 = MessageBox.Show("Загадай число от 0 до " + i + ".\nКак увидешь свое число жми Отмена\n\n\tНачнем игру?", this.caption, MessageBoxButtons.YesNo);
                if (ans1 == DialogResult.Yes)
                {
                    i = i / 2;
                    Mechanism(i);
                    result = MessageBox.Show("Повторим?", caption, MessageBoxButtons.YesNo);
                }
                else
                    return;
            }
            while (result == DialogResult.Yes);
        }



        private void Mechanism(int namb)
        {
            if (namb >= this.check - 1)
            {
                MessageBox.Show(("Загаданное число не может быть больше диапазона!!!"), this.caption, MessageBoxButtons.OK);

            }
            else if (namb <= 1)
            {
                MessageBox.Show(("Загаданное число не может быть меньше диапазона!!!"), this.caption, MessageBoxButtons.OK);
            }
            else {
                DialogResult ans1 = MessageBox.Show(("Загаданное число больше " + namb.ToString() + " ?"), this.caption, MessageBoxButtons.YesNoCancel);
                if (ans1 == DialogResult.Yes)
                {
                    this.counter++;
                    Mechanism(namb = namb + ((this.check - namb) / 2));
                }
                if (ans1 == DialogResult.No)
                {
                    this.counter++;
                    Mechanism(namb = namb - ( namb / 2));
                }
                if (ans1 == DialogResult.Cancel)
                {
                    MessageBox.Show(("Загаданное число!\n\t= " + namb.ToString() + " !!!\n Отгаданно за: " + this.counter.ToString() + " шагов"));
                }
            }
        }

    }
}
