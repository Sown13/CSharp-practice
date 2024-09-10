using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_practice_1.model
{
    public class Practice2 : IPractice
    {
        public void Run()
        {
            System.Console.WriteLine("Practice 2:");
            Console.WriteLine("Count sum of 2 of your input number");
            Console.WriteLine("Enter your first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int total = number1 + number2;
            Console.WriteLine(number1 + " " + number2 + " = " + total);
        }
    }
}