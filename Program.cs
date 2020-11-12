using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CountriesAppFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //create countries app object
            //then use validator class to validate user input
            //then run countries TEST file
            //then run the appropriate method within countries TEXT

            //C:Users\goods\source\repos\countriesappfileio

            string otherTest = @"C:Users\goods\source\repos\countriesappfileio";

            //FILE CREATION
            var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //Without the above, it creates it in my "working directory": C:Users\goods\source\repos\countriesappfileio\debug\netcoreapp3.1 

            string filePathTest = $@"{myDocuments}\countries.txt";
            var firstTest = new CountriesTestFile(); 
            firstTest.CreateFile(filePathTest); //CHECK IF THE FILE EXISTS, CREATE IF IT DOESN'T

            //Creation of countries app
            var test = new CountriesApp(filePathTest);


            try
            {
                test.DisplayMenu();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }



        }
    }
}
