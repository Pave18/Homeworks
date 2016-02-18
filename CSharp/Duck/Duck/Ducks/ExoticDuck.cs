using System;

using programDucks.Fly;
using programDucks.Voise;

namespace programDucks.Ducks
{
    public class ExoticDuck : Duck
    {

        public ExoticDuck() : base(new BaseFly(), new SpecialVoice()) { }

        public override void Show()
        {
            Console.WriteLine("Exotic Duck!");
        }
    }
}
