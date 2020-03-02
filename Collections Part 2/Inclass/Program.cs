//Benjamin HEnke
//collarberated with Cale Reinking 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            string[] Names = new string[3];

           
            
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine("give me the course number youre looking for ");
               Numbers[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please give me the course name youre looking for");
                Names[i] = Convert.ToString(Console.ReadLine());

            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"{Names[i].ToUpper()}{Numbers[i]}");
            }

            string examScore, answer;

            List<int> scores = new List<int>();



            do

            {

                Console.WriteLine($"Please enter your exam score >>");

                scores.Add (Convert.ToInt32(Console.ReadLine());

              

             



                Console.WriteLine("Do you want to input another exam score? yes/no >>");

                answer = Console.ReadLine().ToLower();

            } while (answer.ToLower() == "yes");


           // foreach (var scores in scores)
            //{
               //working towards getting my foreach finished still

               
            //}


            Console.WriteLine($"Your average for the {scores.Count} exam grades is {average.ToString("N3")}.")
            Console.ReadKey();
        }

    }
}
