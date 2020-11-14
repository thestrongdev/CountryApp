using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CountriesAppFileIO
{
    class CountriesTestFile //to create a countries.txt file
    {   
        public static void CreateFile(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
            else
            {
                Console.WriteLine("File exists already");
            }
        }
    }
}
