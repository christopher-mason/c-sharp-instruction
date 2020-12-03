using System;

namespace ch05_methods {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Call some methods");
            // prompts user to enter whole number
            // convert that input to a number
            // print the number

            int n = GetInt("Enter a whole number: ");
            Console.WriteLine("You entered the number: " + n);

            int age = GetInt("Enter actor age: ");
            Console.WriteLine("Actor age is: " + age);

            Console.WriteLine("Bye!");
            }

        private static int GetInt(String prompt) {
            int n = 0;
            Boolean success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    n = int.Parse(Console.ReadLine());
                    success = true;
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid entry. Not a whole number. Try again.");
                }
            }
            return n;
        }
    }
}
