using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_practice_1.model
{
    public class Person
    {
        private string name;
        private int age;

        public Person() { }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }

        public int Age { get => age; set => age = value; }

    }
}