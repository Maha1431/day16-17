using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace datastructure_and_algorithm
{
    class UC12
    {
        public static void Regex1()
        {
            string input = "Hello <<name>>,name as << full name >> in our system.\nyour contact number is 91 - xxxxxxxxxx.\nPlease, let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.";
            Console.WriteLine(input);

            input = Regex.Replace(input, @"<<name>>", "Maha");
            input = Regex.Replace(input, @"<< full name >>", "MahaLakshmi");
            input = Regex.Replace(input, @"1234567899", "");
            input = Regex.Replace(input, @"01 / 11 / 2018", "01 / 11/ 2021");

            Console.WriteLine("\n");
            Console.WriteLine("Replace Details Using Regex");
            Console.WriteLine("\n");
            Console.WriteLine(input);
        }
    }
}
