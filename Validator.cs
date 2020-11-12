using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace CountriesAppFileIO
{
    class Validator 
    {
        private string _userInput;

        public string UserInput { get => _userInput; set => _userInput = value; }

        public Validator(string userInput)
        {
            _userInput = UserInput;
        }

        public Validator()
        {

        }

        public void isNumeric()
        {
            Regex isNum = new Regex(@"^\d$");

            if (isNum.IsMatch(UserInput)){

                Console.WriteLine("Please enter letters only");
            }

        }

        public bool validAction(bool isNum, int Action) {

            return (isNum && Action <= 4 && Action >= 1);
        
        }



    }
}
