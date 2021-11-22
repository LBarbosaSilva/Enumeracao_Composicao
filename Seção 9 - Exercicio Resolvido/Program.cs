using System;
using Seção_9___Exercicio_Resolvido.Entities.Enums;
using Seção_9___Exercicio_Resolvido.Entities;
using System.Globalization;

namespace Seção_9___Exercicio_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dept_name = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double base_salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(dept_name);
            Worker worker = new Worker(name, level, base_salary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mountAndYear = Console.ReadLine();
            int mounth = int.Parse(mountAndYear.Substring(0, 2));
            int year = int.Parse(mountAndYear.Substring(3));

            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: "+ worker.Department.Name);
            Console.WriteLine("Incame for " +mountAndYear + ": " + worker.Income(year, mounth).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
