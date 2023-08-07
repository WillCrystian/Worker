using System;
using Worker.Entities;
using Worker.Entities.Enums;

namespace Worker
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Enter departament's name: ");
            string departName = Console.ReadLine();

            Console.WriteLine("Enter work data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/ MidLevel/ Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());


            Console.Write("Base salary: ");
            int baseSalary = int.Parse(Console.ReadLine());

            Departaments depart = new Departaments(departName);
            Work work = new Work(name, level, baseSalary, depart);


            Console.Write("How many contracts to this worker: ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine();
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (Hour): ");
                int hours = int.Parse(Console.ReadLine());
                HourContracts hourContracts = new HourContracts { Date = data, Hours = hours, ValuePerHour = valuePerHour };
                work.AddContract(hourContracts);
            }


            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Nome:`{work.Name}");
            Console.WriteLine($"Department: {work.Departament.Name}");
            Console.WriteLine($"Income for {monthAndYear}: R${work.Income(year, month)} ");

            Console.ReadKey();

        }
    }
}
