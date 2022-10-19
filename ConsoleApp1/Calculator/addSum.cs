using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Calculator
{
     class AddSum
    {
        public void Addition() 
        {
            Console.Write("Enter a number:");
            var num1 = Console.Read();
            Console.Write("Enter a number");
            var num2 = Console.Read();

            int sum = Convert.ToInt32(num1)+ Convert.ToInt32(num2);

            Console.WriteLine($"the sum is :{sum}");


        }  
    }
}
