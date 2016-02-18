using System;

using programDucks.Fly;
using programDucks.Voise;

namespace programDucks.Ducks
{
    class RubberDuck : Duck
    {
        public RubberDuck() : base(new VoidFly(), new BaseVoise()) { }

        public override void Show()
        {
            Console.WriteLine("Rubber Duck!");
        }
    }
}
