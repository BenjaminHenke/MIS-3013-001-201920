using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P_inclassparticipation_BenjaminHenke
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

                Console.WriteLine(sentence);



            Console.WriteLine("what word are looking for in the sentence above");
            string Place = Console.ReadLine();

            Console.WriteLine("what do you want to change it to?");
            string answer = Console.ReadLine();

            if (sentence.Contains(Place))

            {
                string newsent = sentence.Replace(Place, answer);
                Console.WriteLine(newsent);

            }
            else
            {
                Console.WriteLine($"sorry i could not find your word {answer}");

                for (int i = 0; i > answer.Length - 1; i--)
                {
                    Console.WriteLine(answer[i]);
                }
           
           

               
                
            }        
           

            
         

            Console.ReadKey();

        }

    }
}
