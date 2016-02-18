using System;

namespace programDucks.Voise
{
    public class SpecialVoice : IVoise
    {
        public void Voise()
        {
            Console.WriteLine("Special Quack - Special quack");
            Console.Beep();
            Console.Beep();
        }
    }
}
