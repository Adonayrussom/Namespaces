using sess06_ClassesAndMethods;
using sess09_Properties__and_Indexers;
using System;

namespace sess10_Namespaces
{
    /// <summary>
    /// Program to demonstrate how to work with classes from different namespaces
    /// </summary>
    public class ComparePersons
    {
        static void Main(string[] args)
        {
            //SimplePerson object from session 6
            SimplePerson buddy1 = new SimplePerson();
            //You can prompt the user for the buddy's details but
            //we're going to hard code them into the program
            buddy1.SetNames("Mark Mundu");//-> use your friend's details
            buddy1.SetGender('M');
            buddy1.SetBirthDate(Convert.ToDateTime("1999/08/20"));
            buddy1.SetNationality("Kenyan");
            //Display buddy1's details
            Console.WriteLine(buddy1.ToString());



            //SimplerPerson object from session 9
            SimplerPerson friend2 = new SimplerPerson();
            Console.WriteLine();//Blank line to seperate the buddy/friend objects
            friend2.Names = "Ruth Boaz";
            friend2.Gender = 'F';
            friend2.BirthDate = Convert.ToDateTime("2016/03/25");
            friend2.Nationality = "Israeli";
            //Display friend2's details
            Console.WriteLine(friend2.ToString());
        }
    }
}
