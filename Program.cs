using System.Globalization;

namespace OutSourcedEmployee
{
    public class Program
    {
        public static void Main()
        {

            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int times = int.Parse(Console.ReadLine());

            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine($"\nEmployee Data ({i})\n");
                Console.Write("Outsourced employee? (y/n): ");
                string response = Console.ReadLine();
                if (response == "n")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
                else if (response == "y")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charger: ");
                    double additionalCharger = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharger);
                    employees.Add(employee);
                }
                else
                {
                    Console.WriteLine("\nPlease enter the data correctly\n");
                    break;
                }
            }
            Console.WriteLine("\nPayments: ");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name + " - $ " + e.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}