using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace CountriesAppFileIO
{
    class Validator 
    {
    

        public static void isNumeric(string userInput)
        {
            Regex isNum = new Regex(@"^\d$");

            if (isNum.IsMatch(userInput)){

                Console.WriteLine("Please enter letters only");
            }

        }

        public static bool validAction(bool isNum, int Action) {

            return (isNum && Action <= 4 && Action >= 1);
        
        }



    }
}
