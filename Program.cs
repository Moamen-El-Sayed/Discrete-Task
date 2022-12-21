using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, i, j, flag;

            Console.Write("\n\n Find prime numbers within a given number of range:\n");
            Console.Write("------------------------------------------------------ \n\n");
           
            // Ask user to enter number for starting
            Console.Write(" Enter number for starting : ");
            // Take input
            num1 = int.Parse(Console.ReadLine());

            // Ask user to enter number for ending
            Console.Write(" Enter number for ending : ");
            // Take input
            num2 = int.Parse(Console.ReadLine());

            // Print display message
            Console.WriteLine("\nPrime numbers between " +
                    "{0} and {1} are: ", num1, num2);

            // Traverse each number in the interval
            // with the help of for loop
            for (i = num1; i <= num2; i++)
            {

                // Skip 0 and 1 as they are
                // neither prime nor composite
                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell
                // if i is prime or not
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }    
     
    }
}
