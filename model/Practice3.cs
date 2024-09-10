using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_practice_1.model
{
    public class Practice3 : IPractice
    {
        public void Run()
        {
            System.Console.WriteLine("Practice 3, counting spaces:");
            System.Console.WriteLine("Enter your string:");
            string? input = System.Console.ReadLine();
            int count = input.Count(c => c == ' ');
            System.Console.WriteLine("Total spaces in your string " + " '" + input + " is': " + count);
        }
    }
}