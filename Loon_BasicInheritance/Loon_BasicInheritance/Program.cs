using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and object
            Person person = new Person();

            //call the method from car class
            person.CarInfo();

            //Display the value 
            Console.WriteLine("\nModer: " + person.carModel + "\nOwner: " + person.ownerName);

            Console.ReadKey();
        }
    }
}
