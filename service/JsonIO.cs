using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using cs_practice_1.model;

namespace cs_practice_1.service
{
    public class JsonIO
    {
        public static void Write(Person person, string fileName)
        {
            List<Person> personList;

            // read file
            if (File.Exists(fileName))
            {
                string existString = File.ReadAllText(fileName);
                personList = JsonSerializer.Deserialize<List<Person>>(existString) ?? [];
            }
            else
            {
                personList = []; // Create a new list if the file does not exist
            }

            personList.Add(person);

            string jsonString = JsonSerializer.Serialize(personList, new JsonSerializerOptions { WriteIndented = true });

            // Write JSON to a file
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine("JSON written to file.");
        }

        public static void Read(string fileName)
        {
            // Read JSON from a file
            string jsonString = File.ReadAllText(fileName);

            List<Person> personList = new List<Person>();
            // Deserialize JSON to an object
            if (File.Exists(fileName))
            {
                string existString = File.ReadAllText(fileName);
                personList = JsonSerializer.Deserialize<List<Person>>(existString) ?? new List<Person>();
            }
            else
            {
                personList = new List<Person>(); // Create a new list if the file does not exist
            }

            // Display the object's properties
            foreach (Person person in personList)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}