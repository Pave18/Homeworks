using System;
using System.Threading;

namespace Task
{
    public class Parking
    {
        public static SemaphoreSlim parking = new SemaphoreSlim(2);

        public void ImitateParkingProcess(Car[] cars)
        {
            foreach (var car in cars)
                new Thread(ParkingProcess).Start(car);
        }

        static void ParkingProcess(object item)
        {
            Car car = item as Car;
            Random rnd = new Random();
            bool isStillWaiting = car.WaitForParkingPlace(rnd.Next(0, 10));
            if (isStillWaiting)
            {
                parking.Wait();
                car.Park();
                car.Stay();
                car.Leave();
                parking.Release();
            }
        }
    }
}
