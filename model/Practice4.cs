using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_practice_1.model
{
    public class Practice4 : IPractice
    {
        public void Run()
        {
            System.Console.WriteLine("Practice 4, calculate total of number in array:");
            System.Console.WriteLine("Enter length of your array:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            System.Console.WriteLine("Enter value of each number in your array: ");
            for (int i = 0; i < array.Length; i++){
                System.Console.WriteLine("Enter value of number "+ (i + 1));
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
            }
            System.Console.WriteLine("Here your array: ");
            System.Console.Write("[");
            System.Console.Write(string.Join(", ", array));
            System.Console.WriteLine("]");
            System.Console.WriteLine("This array have sum: " + array.Sum());
        }
    }
}