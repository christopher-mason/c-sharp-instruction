using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            // this is a single line comment

            /*
             * this is a block comment
             */
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter first name: ");
            String firstName = Console.ReadLine();
            Console.Write("Hello, ");
            Console.WriteLine(firstName + "!");
            }
        }
    }
