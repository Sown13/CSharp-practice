using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_practice_1.model
{
    public class Practice5 : IPractice
    {
        public void Run()
        {
            System.Console.WriteLine("Practice 5, rotate an array:");
            System.Console.WriteLine("Enter length of your array:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            System.Console.WriteLine("Enter value of each number in your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine("Enter value of number " + (i + 1));
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
            }
            System.Console.WriteLine("Here your array: ");
            System.Console.Write("[");
            System.Console.Write(string.Join(", ", array));
            System.Console.WriteLine("]");

            RotateArrayLeft(array);
            System.Console.WriteLine("Here your array after rotate to the left: ");
            System.Console.Write("[");
            System.Console.Write(string.Join(", ", array));
            System.Console.WriteLine("]");
        }

        internal void RotateArrayLeft(int[] array)
        {
            int temp = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 >= array.Length)
                {
                    array[i] = temp;
                    return;
                }
                array[i] = array[i + 1];
            }
        }
    }
}