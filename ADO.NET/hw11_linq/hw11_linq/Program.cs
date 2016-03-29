using System;
using System.Collections.Generic;
using System.Linq;

using hw11_linq.Classes;

namespace hw11_linq
{

    class Program
    {

        static void Main()
        {
            AddDB();
            Show();

            var rez1 = from e in employees
                       from d in departments
                       where e.DepId == d.Id
                       where (d.Country == "Ukraine" && d.City != "Donetsk")
                       select new { e.FirstName, e.LastName };
            Console.WriteLine("\n\t\t_rez1_");
            foreach (var item in rez1)
                Console.WriteLine($"{item.FirstName} {item.LastName}");

            var rez2 = departments.Select(x => x.Country).Distinct();
            Console.WriteLine("\n\t\t_rez2_");
            foreach (var item in rez2)
                Console.WriteLine(item);

            var rez3 = employees.Where(x => x.Age > 25).Take(3);
            Console.WriteLine("\n\t\t_rez3_");
            foreach (var item in rez3)
                Console.WriteLine($"{item.FirstName} {item.LastName}");

            var rez4 = from e in employees
                       from d in departments
                       where e.Age>23 && e.DepId == d.Id
                       where (d.City == "Kyiv")
                       select new { e.FirstName, e.LastName, e.Age };
            Console.WriteLine("\n\t\t_rez4_");
            foreach (var item in rez4)
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");

            Console.ReadLine();
        }


        public static List<Department> departments;
        public static List<Employee> employees;

        public static void AddDB()
        {
            departments = new List<Department>()
            {
                new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
                new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department(){ Id = 3, Country = "France", City = "Paris" },
                new Department(){ Id = 4, Country = "Russia", City = "Moscow" }
                };

            employees = new List<Employee>()
            {
                new Employee(){ Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee(){ Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee(){ Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee(){ Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                new Employee(){ Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee(){ Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                new Employee(){ Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27,DepId = 4 }
            };
        }

        public static void Show()
        {
            Console.WriteLine("\t\t\t__Personal__");
            foreach (var item in employees)
            {
                Console.Write("Id: " + item.Id +
                    " FName: " + item.FirstName +
                    " LName: " + item.LastName +
                    " Age: " + item.Age +
                    " Country: " + (departments[item.DepId - 1]).Country +
                    " City: " + (departments[item.DepId - 1]).City);
                Console.WriteLine();
            }

        }
    }
}
