using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentdetails
{

    class Program
    {
        static void Main()
        {
            string filePath = "D:\\mphasis\\dotnet\\Studentdetails\\student";

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Student Data");
                Console.WriteLine("");
                Console.WriteLine("ID\tNAME\tAGE\tPLACE\tQUALIFICATION");
                // Display each line (student data) on the console
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: File '{filePath}' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadLine(); 
        }
    }

}
