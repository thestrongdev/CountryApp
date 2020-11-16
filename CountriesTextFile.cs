using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CountriesAppFileIO
{
    class CountriesTextFile 
    {
    
        public static void OutputTxt(List<string> countries)
        {
            foreach (string line in countries)
            {
                Console.WriteLine(line);
            }
        }

        public static void ReadTxt(string textFile, List<string> countries)
        {
            if (countries.Count == 0) //or if _countries.Count == 0
            {
                Console.WriteLine("File is empty. There is nothing to read and display");
            }
            else
            {
                File.ReadAllLines(textFile);
                OutputTxt(countries);
            }
        }

        public static void WriteToTxt(string textFile, List<string> countries)
        {

            Console.WriteLine("\nPlease enter a country name to add: ");
            string userCountry = Console.ReadLine();

            countries.Add(userCountry.ToLower());

            File.WriteAllLines(textFile, countries);

            Console.WriteLine("\nHere is the new list");

            OutputTxt(countries);
        }

        public static void DeleteLine(string textFile, List<string> countries)
        {
            Console.WriteLine("\nPlease enter a country name to delete: ");
            string userCountry = Console.ReadLine();

            if (countries.Contains(userCountry, StringComparer.OrdinalIgnoreCase)) //USE EQUALS INSTEAD OF CONTAIN?? NEED TO IGNORE CASE
            {
                countries.Remove(userCountry.ToLower());
                File.WriteAllLines(textFile, countries);

                Console.WriteLine("Here is the new list");

                OutputTxt(countries);
            }
            else
            {
                Console.WriteLine("That file does not exist");
            }

        }
    }
}