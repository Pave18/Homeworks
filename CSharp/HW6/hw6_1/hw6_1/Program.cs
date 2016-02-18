using System;
using System.Collections;

namespace hw6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection_Int64 A = new Collection_Int64();

            A.Add(53);
            A.Add(566);
            A.Add(5443);

            for (int i = 0; i < 3; ++i)
                Console.WriteLine("Collection_Int64 A[" + i + "] = " + A[i]);


            Console.WriteLine();
        }
    }


    public class Collection_Int64 : CollectionBase
    {
        public Int64 this[int index]
        {
            get { return ((Int64)List[index]); }
        }

        public Int64 Add(Int64 value) { return (List.Add(value)); }
    }
}
