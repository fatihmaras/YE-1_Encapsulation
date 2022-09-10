using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AddClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Ahmet";   // set bloğu çalışır
            employee.LastName = "Türkoğlu";
            employee.Age = 25;
            Console.WriteLine(employee.FirstName); // get bloğu çalışır.
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.Age);

            Console.WriteLine("\n");

            Employee employee2 = new Employee("Mehmet", "Üstün", 18);

            Console.WriteLine(employee2.FirstName);


            Console.ReadLine();

        }

    }
}
