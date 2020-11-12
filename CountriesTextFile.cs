using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CountriesAppFileIO
{
    class CountriesTextFile 
    {
        private string _textFile;
        private List<string> _countries;
    
        public CountriesTextFile()
        {

        }

        public CountriesTextFile(List<string> countries, string textFile)
        {
            _countries = countries;
            _textFile = textFile;
        }

        public void OutputTxt()
        {
            foreach (string line in _countries)
            {
                Console.WriteLine(line);
            }
        }

        public void ReadTxt()
        {
            if (_countries.Count == 0) //or if _countries.Count == 0
            {
                Console.WriteLine("File is empty. There is nothing to read and display");
            }
            else
            {
                File.ReadAllLines(_textFile);
                OutputTxt();
            }
        }

        public void WriteToTxt()
        {

            Console.WriteLine("Please enter a country name to add: ");
            string userCountry = Console.ReadLine();

            _countries.Add(userCountry);

            File.WriteAllLines(_textFile, _countries);

            Console.WriteLine("Here is the new list");

            OutputTxt();
        }

        public void DeleteLine()
        {
            Console.WriteLine("Please enter a country name to delete: ");
            string userCountry = Console.ReadLine();

            if (_countries.Contains(userCountry))
            {
                _countries.Remove(userCountry);
                File.WriteAllLines(_textFile, _countries);

                Console.WriteLine("Here is the new list");

                OutputTxt();
            }
            else
            {
                Console.WriteLine("That file does not exist");
            }

        }
    }
}