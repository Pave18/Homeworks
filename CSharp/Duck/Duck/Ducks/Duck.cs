using System;

using programDucks;
using programDucks.Fly;
using programDucks.Voise;

namespace programDucks.Ducks
{
    public abstract class Duck
    {
        private IFly fly { get; set;}
        private IVoise voise { get; set; }

        public Duck()
        {
            fly = new BaseFly();
            voise = new BaseVoise();
        }
        protected Duck(IFly fly, IVoise voise)
        {
            this.fly = fly;
            this.voise = voise;
        }

        public abstract void Show();

        public void Swim()
        {
            Console.WriteLine("Swim!");
        }

        public virtual void Voise()
        {
            voise.Voise();
        }

        public void Fly()
        {
            fly.Fly();
        }

    }
}
