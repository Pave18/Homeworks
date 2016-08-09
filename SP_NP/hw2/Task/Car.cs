using System;
using System.Threading;

namespace Task
{
    public class Car
    {
        public string Model { get; set; }
        public string Number { get; set; }

        public bool WaitForParkingPlace(int time)
        {
            Console.WriteLine($"{Model}, {Number} is waiting for parking place...");
            Random rnd = new Random();
            int waitingTime = rnd.Next(0, 9);
            if (waitingTime < time)
            {
                Console.WriteLine($"{Model}, {Number} can't wait no more and moves out!");
                return false;
            }
            return true;
        }

        public void Park()
        {
            Console.WriteLine($"{Model}, {Number} has parked!");
        }

        public void Stay()
        {
            Console.WriteLine($"{Model}, {Number} is staying on the parking place.");
            Thread.Sleep(1000);
        }

        public void Leave()
        {
            Console.WriteLine($"{Model}, {Number} has left the parking place!");
        }
    }
}
