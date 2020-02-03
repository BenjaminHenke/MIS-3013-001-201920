using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_summ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what number do you want to count up to?");
            int threshold = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= threshold; i++)
            {
                Console.WriteLine(i + " ");
            }

        
            Console.ReadKey();
        }

    }
}
