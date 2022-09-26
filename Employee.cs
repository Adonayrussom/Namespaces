using sess09_Properties__and_Indexers;
using System;
namespace sess10_Namespaces
{
    /// <summary>
    /// Base class of Employee objects that derives from the SimplerPerson class
    /// </summary>
    public class Employee : SimplerPerson
    {
        public uint EmpID { get; set; }

        //Override the ToString() method
        public override String ToString()
        {
            return ($"\nEmployee Details"
                    + "\n------------------------------"
                    + $"\nEmployee ID: {this.EmpID}"
                    + $"\nEmployee Names: {this.Names}"
                    + $"\nEmployee Date of Birth: {this.BirthDate:d}"
                    + $"\nEmployee Gender: {(this.Gender == 'M' ? "Male" : "Female")} "
                    + $"\nEmployee Nationality: {this.Nationality}"
                    );
        }
    }

    //Create a nested namespace
    namespace Salary
    {
        /// <summary>
        /// Class pertaining to employee salar details
        /// </summary>
        public class SalaryDetail
        {
            public double EmployeeSalary { get; set; }
            public void DisplaySalary()
            {
                Console.WriteLine($"Salary amount: {this.EmployeeSalary:C}"
                    + "\n------------------------------");
            }
        }
    }
}
