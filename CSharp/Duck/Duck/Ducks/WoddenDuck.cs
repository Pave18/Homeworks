using System;

using programDucks.Fly;
using programDucks.Voise;

namespace programDucks.Ducks
{
    public class WoddenDuck : Duck
    {
        public WoddenDuck() : base(new VoidFly(), new VoidVoise()) { }

        public override void Show()
        {
            Console.WriteLine("Wodden Duck!");
        }
    }
}