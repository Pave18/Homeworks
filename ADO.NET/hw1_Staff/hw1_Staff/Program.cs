using System;
using hw1_Staff.Datebase_;

using System.Data.SqlClient;

namespace hw1_Staff
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DatabaseStaff DS = new DatabaseStaff();
                Console.WriteLine("\t\tAllEmployee\n");
                DS.ShowAllEmployee();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
