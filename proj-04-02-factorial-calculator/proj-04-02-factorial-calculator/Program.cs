using System;

namespace proj_04_02_factorial_calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Factorial Calculator");

            int number = 0;
            long factorial = 1;

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter an integer that is greater than zero but less than 10: ");
                number = Int32.Parse(Console.ReadLine());
                factorial = 1;
                for (int i = 1; i <= number; i++) {
                    factorial = factorial * i;
                    }
                if (number > 10) {
                    Console.WriteLine("Error! Invalid integer.");
                    }
                Console.WriteLine("The factorial of " + number + " is " + factorial);
                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
                }


            Console.WriteLine("Bye!");

            }
        }
    }
