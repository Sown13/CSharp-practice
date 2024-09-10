using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cs_practice_1.service;

namespace cs_practice_1.model
{
    public class Practice6 : IPractice
    {
        private static readonly string fileName = "person.json";
        public void Run()
        {
            System.Console.WriteLine("Practice 6, create Person and write to the json file");
            System.Console.WriteLine("Enter the person name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the person age");
            int age = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, age);
            JsonIO.Write(person, fileName);
        }
    }
}