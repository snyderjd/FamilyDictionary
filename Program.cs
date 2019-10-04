using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Sandy"},
                {"age", "66"}
            });

            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Don"},
                {"age", "66"}
            });

            foreach(KeyValuePair<string, Dictionary<string, string>> person in myFamily)
            {
                Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]} years old.");
                Console.WriteLine("--------------------");
            }
        }
    }
}

// foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
// {
//     ... your code here
// }

// Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

// myFamily.Add("sister", new Dictionary<string, string>(){
//     {"name", "Krista"},
//     {"age", "42"}
// });