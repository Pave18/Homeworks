using System;
using System.Collections.Generic;
using System.Threading;

namespace Task1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Car> LCar = new List<Car>()
            {
                new Car { Brand = "Moskvich", Model = "2140" },
                new Car { Brand = "Nissan", Model = "Sunny" },
                new Car { Brand = "Toyota", Model = "MarkII" },
            };

            Thread t = new Thread(() => LCar.ForEach(c => Console.WriteLine(c)));
            t.Start();
        }
    }
}
