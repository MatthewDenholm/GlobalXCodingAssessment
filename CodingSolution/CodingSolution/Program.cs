using System;
using System.Collections.Generic;

namespace CodingSolution
{
    class Program
    {
        private static string path;

        static void Main(string[] args)
        {
            List<People> allPeople = new List<People>();
            path = Console.ReadLine();
            string[] nameStrings = System.IO.File.ReadAllLines(path);
            
            for(int i = 0;i<nameStrings.Length;i++)
            {
                string[] splitNames = nameStrings[i].Split(" ");
                int nameCount = splitNames.Length;
                People person;
                switch(nameCount){
                    case 1:
                        person = new People(splitNames[0]);
                        allPeople.Add(person);
                        break;

                    case 2:
                        person = new People(splitNames[0], splitNames[1]);
                        allPeople.Add(person);
                        break;

                    case 3:
                        person = new People(splitNames[0], splitNames[1], splitNames[2]);
                        allPeople.Add(person);
                        break;
                }
            }
            allPeople.Sort((x, y) => x.getLastName().CompareTo(y.getLastName()));
            for(int j = 0; j < allPeople.Count; j++)
            {
                Console.WriteLine(allPeople[j].toString());
            }
            
            path = Console.ReadLine();

        }
    }
}
