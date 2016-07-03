using System.IO;
using System.Threading;

namespace Task2
{
    class Bank
    {
        private int money;
        private int persent;
        private string name;
        private static readonly string filename = "BankInfo.txt";
        private static readonly StreamWriter sw = File.CreateText(filename);

        ~Bank()
        {
            sw.Close();
        }

        public int Money
        {
            get { return money; }
            set
            {
                if (value == money)
                    return;
                else
                {
                    Thread t = new Thread(() => sw.WriteLine($"Bank: {name} {money} {persent}: changed from {money} to {value}"));
                    t.Start();
                    money = value;
                }
            }
        }

        public int Persent
        {
            get { return persent; }
            set
            {
                if (value == persent)
                    return;
                else
                {
                    Thread t = new Thread(() => sw.WriteLine($"Bank: {name} {money} {persent}: changed from {persent} to {value}"));
                    t.Start();
                    persent = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == name)
                    return;
                else
                {
                    Thread t = new Thread(() => sw.WriteLine($"Bank: {name} {money} {persent}: changed from {name} to {value}"));
                    t.Start();
                    name = value;
                }
            }
        }
    }
}
