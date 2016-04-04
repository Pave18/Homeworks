using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodsDataContext db = new GoodsDataContext();

            var result =
                    from T in db.Table_1
                    select T;

            foreach (var t in result)
            {
                Console.WriteLine($"{t.Id} {t.Title} {t.Category} {t.Weight} {t.Price}");
            }

            int result1 =
                    (from t in db.Table_1
                     where t.Weight > 1
                     select t).Count();

            Console.WriteLine($"\n Goods Weight > 1 = {result1}");

            //int result2 =
            //        (from t in db.Table_1
            //         where t.Weight > 1
            //         select t).Count();

        }
    }
}
