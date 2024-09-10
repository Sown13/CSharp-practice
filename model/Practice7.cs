using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cs_practice_1.service;

namespace cs_practice_1.model
{
    public class Practice7 : IPractice
    {
        private static readonly string fileName = "person.json";
        public void Run()
        {
            System.Console.WriteLine("Practice 7, read person from json file");
            JsonIO.Read(fileName);
        }
    }
}