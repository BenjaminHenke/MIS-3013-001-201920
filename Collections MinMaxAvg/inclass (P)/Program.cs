using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass__P_
{
    class Program
    {
        static void Main(string[] args)
        {
            double ExamGrade;
            string Response = " ";

            do
            {
                Console.WriteLine("Please enter your exam Grades. >>");
                ExamGrade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Would you like to enter another exam grade?");
                Response = Console.ReadLine();
                List<double> Grades = new List<double>();
                Grades.Add(ExamGrade);

            }
            while (Response == "yes");
            {

            }

            double ;
            
            for (int i = 0; i < length; i++)
            {

            }






            // List<double> Grades = new List<double>();
            //Grades.Add(eMax);
            //Grades.Add(eMax);
            //Grades.Add(eMax);
            //Grades.Add(eMax);










            Console.ReadKey();
        }
    }
}
