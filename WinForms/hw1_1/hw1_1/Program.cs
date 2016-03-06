using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1_1
{
    static class Program
    {
        static DialogResult ShowMessageBoxes()
        {
            string caption = "Резюме";
            string summStr = null;

            string message1 = "Имя: Егор \nФамилия: Павленко"; MessageBox.Show(message1, caption);
            summStr += message1;
            string message2 = "Дата рождения: 1996-04-30"; MessageBox.Show(message2, caption);
            summStr += message2;
            string message3 = "Студент"; MessageBox.Show(message3, caption);
            summStr += message3;

            int size = summStr.Length /3;

            string message = ("Среднее количество символов на " + 3 + " MessageBox = " + size + " символов");
            DialogResult result = MessageBox.Show(message, "Итого", MessageBoxButtons.OK);

            return result;
        }

        [STAThread]
        static void Main()
        {
            DialogResult result;
            do
            {
                result = ShowMessageBoxes();
            } while (result == DialogResult.Retry);
        }
    }
}
