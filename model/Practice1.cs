using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_practice_1.model
{
    public class Practcice1 : IPractice
    {
        public void Run(){
            System.Console.WriteLine("Practice 1:");
            System.Console.WriteLine("Enter your input:");
            string? yourInput = Console.ReadLine();
            System.Console.WriteLine("Here is your input:");
            System.Console.WriteLine(yourInput);
        }
    }
}