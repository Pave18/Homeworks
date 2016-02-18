using System;
using System.Collections.Generic;

using programDucks.Ducks;

namespace programDucks
{
    class Example
    {
        public static void Main()
        {
            List<Duck> listDuck = new List<Duck>
        {
            new ExoticDuck(),
            new GrayDuck(),
            new RubberDuck(),
            new WoddenDuck()
        };

            foreach (var duck in listDuck)
            {
                duck.Show();
                duck.Voise();
                duck.Swim();
                duck.Fly();

                Console.WriteLine("================");
            }

            
            Console.ReadLine();
        }
    }
}