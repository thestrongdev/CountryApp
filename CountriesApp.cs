using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CountriesAppFileIO
{
    class CountriesApp
    {
        //public string userAction { get; set; }
        //public int Action { get; set; }
        //private string _textFile;

        //private Dictionary<string, string> _menuOptions; //USE LATER

        //public Dictionary<string, string> MenuOptions { get => _menuOptions; set => _menuOptions = value; } //USE LATER
        //public List<string> Countries { get => _countries; set => _countries = value; }
        //public string TextFile { get => _textFile; set => _textFile = value; }

        //private List<string> _countries;

        //public CountriesApp()
        //{

        //}

        //public CountriesApp(string path, List<string> countries)
        //{
        //    TextFile = path;
        //}


        public static void DisplayMenu(string textFile, List<string> countries)
        {
            Console.WriteLine("Welcome to the countries app!");
            Console.WriteLine();
            bool play = true;

            Dictionary<int, string> fileOptions = new Dictionary<int, string>
            {
                {1, "Read & Display" },
                {2, "Add" },
                {3, "Delete" },
                {4, "Exit" }

            };

            do
            {
                Console.WriteLine("\nPlease choose one of the below options by entering an integer: \n" +
                    "1) Read & Display\n" +
                    "2) Add\n" +
                    "3) Delete\n" +
                    "4) Exit");
                Console.WriteLine();

                string userAction = Console.ReadLine();

                bool isNum = int.TryParse(userAction, out int Action);

                if (Validator.validAction(isNum, Action)) //INSTEAD USE VALIDATOR CLASS PRIOR TO BELOW IF STATEMENTS once finish with main tasks
                {
                    if(Action == 1)
                    {
                        Console.WriteLine($"\nYou chose {fileOptions[Action]}!");
                        CountriesTextFile.ReadTxt(textFile, countries);

                    } else if(Action == 2)
                    {
                        Console.WriteLine($"\nYou chose {fileOptions[Action]}!");
                        CountriesTextFile.WriteToTxt(textFile, countries);

                    } else if (Action == 3)
                    {
                        Console.WriteLine($"\nYou chose {fileOptions[Action]}!");
                        CountriesTextFile.DeleteLine(textFile, countries);
                    }
                    else
                    {
                        Console.WriteLine("GOODBYE");
                        play = false;
                    }

                }
                else
                {
                    Console.WriteLine("\nInvalid Entry...must be integer between 1 and 4");
                }
                
                

            } while (play);

        }
            //create dictionary list of menu in validation file???
            //see what option is in the dictionary
        



        



    }
}
