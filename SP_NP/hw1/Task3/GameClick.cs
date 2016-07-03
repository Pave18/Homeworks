using System;
using System.Threading;

namespace Task3
{
    public class GameClick
    {
        private long milliseconds;
        private Timer timer;

        public GameClick()
        {
            this.milliseconds = 0;
            this.timer = new Timer((o) => ++milliseconds);
        }

        public void GameStart()
        {
            Console.WriteLine("Game \"Things to press the button.\"");
            Console.WriteLine("Ready?");
            Console.ReadKey();

            OneTwoThree();

            timer.Change(0, 15);
            Console.WriteLine("Press!");
            Console.ReadKey();

            Result();

            timer.Dispose();
        }

        private void OneTwoThree()
        {

            Thread.Sleep(500);
            Console.WriteLine("1!");
            Thread.Sleep(500);
            Console.WriteLine("2!");
            Thread.Sleep(500);
            Console.WriteLine("3!");
        }

        private void Result()
        {
            Console.WriteLine($"\nYour result is {this.milliseconds * 15} milliseconds");
            long seconds = (this.milliseconds * 15) / 1000;
            long Mseconds = (this.milliseconds * 15) - (1000 * seconds);
            Console.WriteLine($"Or your result is {seconds} seconds {Mseconds} milliseconds ");
        }
    }
}
