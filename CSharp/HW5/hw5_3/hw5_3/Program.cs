using System;

namespace hw5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = { 5, "String", 4, 5.6525, true, 1, 8 };
            string key = "String";
            SearchElement(array, key);
        }

        public delegate bool Search(object next, object key);

        static void SearchElement(object[] obj, object key)
        {
            Search temp = new Search(CompareElements);

            foreach (object o in obj)
                if (temp(o, key))
                {
                    Console.WriteLine("The object has been found.");
                    return;
                }

            Console.WriteLine("Object not found");
        }

        static bool CompareElements(object next, object key)
        {
            if (next.Equals(key))
                return true;
            return false;
        }

    }
}
