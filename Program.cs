using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, i, sum, mn, mx;
 
            Console.Write(" \n\n Find perfect numbers within a given number of range:\n");
            Console.Write("------------------------------------------------------ \n\n");
           
            // Ask user to enter number for starting
            Console.Write("Input the starting range or number : ");
            // Take input
            mn = Convert.ToInt32(Console.ReadLine());

            // Ask user to enter number for ending
            Console.Write("Input the ending range of number : ");
            // Take input
            mx = Convert.ToInt32(Console.ReadLine());

            // Print display message
            Console.Write("The Perfect numbers within the given range : ");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
            Console.ReadKey();






        }
    }
}
