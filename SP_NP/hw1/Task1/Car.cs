namespace Task1
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"Brand: {Brand} Model: {Model}";
        }
    }
}
