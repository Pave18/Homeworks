namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
           {
                new Car { Model = "BMW", Number = "6666"},
                new Car { Model = "Moskvich", Number = "3333"},
                new Car { Model = "Zaz", Number = "2222"},
                new Car { Model = "Audi", Number = "4444"},
                new Car { Model = "Mercedes", Number = "5555"},
                new Car { Model = "Dodge", Number = "1111"}
           };

            Parking p = new Parking();
            p.ImitateParkingProcess(cars);
        }
    }
}
