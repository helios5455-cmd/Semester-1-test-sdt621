using System;
using System.IO;
using System.Collections.Generic;

namespace app
{
    class Program
    {
        private string userName;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            try
            {
                Console.WriteLine("Welcome to the structure of a C# program");
                Console.Write("Enter your name: ");
                userName = Console.ReadLine();
                Console.WriteLine($"Hello {userName}!");
                Console.WriteLine("Program structure Demonstrated :");
                Console.WriteLine("1. using System : imports functionality");
                Console.WriteLine("2. namespace  : organizes code");
                Console.WriteLine("3. class Program : container for code");
                Console.WriteLine("4. Main() : entry point of program");
                Console.WriteLine("5. Comments : explain logic and documentation");
                Console.WriteLine("Program executed successfully!");
                WriteToFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void WriteToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    writer.WriteLine("Welcome to the structure of a C# program");
                    writer.WriteLine($"Hello {userName}!");
                    writer.WriteLine("Program structure Demonstrated :");
                    writer.WriteLine("1. using System : imports functionality");
                    writer.WriteLine("2. namespace  : organizes code");
                    writer.WriteLine("3. class Program : container for code");
                    writer.WriteLine("4. Main() : entry point of program");
                    writer.WriteLine("5. Comments : explain logic and documentation");
                    writer.WriteLine("Program executed successfully!");
                }
                Console.WriteLine("Output written to output.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }
    }
}