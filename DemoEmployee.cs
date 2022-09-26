using sess10_Namespaces.Salary;
using System;

namespace sess10_Namespaces
{
    /// <summary>
    /// Program demonstrate how to work with custom namespaces from the same project
    /// </summary>
    public class DemoEmployee
    {
        static void Main(string[] args)
        {
            //Declare and instantiate an Employee object/instance
            Employee employee = new Employee();
            //Prompt the user for the employee's details

            Console.WriteLine($"Please enter employee's name -> ");
            employee.Names = Console.ReadLine();

            Console.WriteLine($"Please enter {employee.Names} employee's ID -> ");
            employee.EmpID = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter {employee.Names} employee's DOB -> ");
            employee.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter {employee.Names} employee's gender -> ");
            employee.Gender = char.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter {employee.Names} employee's nationality -> ");
            employee.Nationality = Console.ReadLine();

            //Create and Instantiate a SalaryDetails object
            SalaryDetail empSalary = new SalaryDetail();
            Console.WriteLine($"Please enter {employee.Names} employee's salary -> ");
            empSalary.EmployeeSalary = Convert.ToDouble(Console.ReadLine());

            //Display the employee and their salary details
            Console.WriteLine(employee.ToString());
            empSalary.DisplaySalary();
        }
    }
}
