//Benjamin Henke
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Ben_Henke
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an integar name firstName
            string firstName;


            //Assign a value to firstName (your name)
            firstName = "Ben";

            //Create an int named favoriteNumber and assign your favorite number to it
            int favoriteNumber = 7;

            double crazyNumber = 7.6767 * favoriteNumber;

            string lastName = "Henke";
            string fullName = firstName + lastName;

            Console.WriteLine(fullName + "has the favorite number of" + favoriteNumber +  "\nwhich equates to a crazy number of" + crazyNumber);


            //Make it Dynamic
            Console.WriteLine("Please enter your first name: >>");
            firstName = Console.ReadLine();


            Console.WriteLine("Please enter your last name: >>");
           lastName = Console.ReadLine();


            Console.WriteLine("Please enter your favorite number: >>");
            

            favoriteNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fullName + "has the favorite number of" + favoriteNumber + "\nwhich equates to a crazy number of" + crazyNumber);



            Console.ReadKey();
        }
    }
}
