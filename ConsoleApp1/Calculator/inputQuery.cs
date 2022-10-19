using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Calculator
{
    internal class inputQuery
    {
        /*asking user for their input*/
        public static int[] UserQuery()
        {
            int [] result = new int[2];

            Console.Write("Enter a number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            result[0] = n1;
            result[1] = n2;

            return result;


        }
    }
}
