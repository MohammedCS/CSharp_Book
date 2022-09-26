// #error version
global using System.Linq; // import the namespace to all the project files
using System; // import the System namespace
using System.Collections.Generic;
using System.Reflection; // for program_2

namespace Chapter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program_1 :
                // outputs the current line terminator string(\r\n)
                // by default, this is a carriage-return(\r) and line feed(\n)
                Console.WriteLine();

                // outputs the greeting and the current line terminator string(\r\n)
                Console.WriteLine("Hello, C#!");

                // outputs a formated number and date and the current line terminator string(\r\n)
                Console.WriteLine("Temperature on {0:D} is {1}°C", DateTime.Today, 23.4);
            */

            /* Program_2 : 
                Assembly? assembly = Assembly.GetEntryAssembly();
                if (assembly == null) return;

                // loop through the assemplies that this app references
                foreach (AssemblyName name in assembly.GetReferencedAssemblies())
                {
                    // load the assembly so we can read its details
                    Assembly a = Assembly.Load(name);

                    // declare a variable to count the number of methods
                    int methodCount = 0;

                    // loop through all the types in the assembly
                    foreach (TypeInfo t in a.DefinedTypes)
                    {
                        // add up the count of methods
                        methodCount += t.GetMethods().Count();
                    }

                    // output the count of types and their methods
                    Console.WriteLine(
                        "{0:N0} types with {1:N0} methods in {2} assembly.",
                        arg0: a.DefinedTypes.Count(),
                        arg1: methodCount,
                        arg2: name.Name);
                }
            */

            /* Program_3 :
                // let the heightInMetres variable become equal to the value 1.88
                double heightInMetres = 1.88;
                Console.WriteLine($"The Variable {nameof(heightInMetres)} has the value {heightInMetres}."); 
            */

            /* Program_4 :
                char letter = 'A'; // assigning literal characters
                char digit = '1';
                char symbol = '$';
                char userChoice= GetSomeKeyStroke(); // assigning from a fictitious function

                string firstName = "Bob"; // assigning literal string
                string lastName = "Smith";
                string phoneNumber = "(215) 555-5256";

                // assigning a string returned from a ficitious function
                string address = GetAddressFromDatabase(id: 563);

                // Using verbatim strings
                string fullNameWithTabSeparator = "Bob\tSmith";
                string filePath = "C:\televisions\sony\bravia.txt"; // will print tab in \t
                string filePathVerbatim = @"C:\television\sony\bravia.txt"
            */

            Console.ReadKey();
        }
    }
}