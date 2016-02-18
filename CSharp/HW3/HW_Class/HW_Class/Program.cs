using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Class
{
    abstract class Board
    {
        public string Name;

        public Board(string name)
        {
            this.Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Phhhh...AAAaa");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Brand: " + Name);
        }

        public abstract void RidesOn();
    }

    class Snow : Board
    {
        public Snow(string name = "NoName") : base(name)
        {
            Console.WriteLine("Snow created!");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        public override void RidesOn()
        {
            Console.WriteLine($"{Name} rides on the snow.");
        }
    }

    class Skate : Board
    {
        public Skate(string name = "NoName") : base(name)
        {
            Console.WriteLine("Skate created!");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        public override void RidesOn()
        {
            Console.WriteLine($"{Name} rides on the asphalt.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Board[] board = { new Skate("Element"), new Snow("SnowBear") };
            Console.WriteLine();

            foreach (Board b in board)
            {
                b.Sound();
                b.ShowInfo();
                b.RidesOn();
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
