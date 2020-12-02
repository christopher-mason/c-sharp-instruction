using System;

namespace proj_04_01_table_of_powers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome tot he Squares and Cubes Table");

            int i;
            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter Integer: ");
                i = Int32.Parse(Console.ReadLine());
                int squared = 0;
                int cubed = 0;

                Console.WriteLine("Number\tSquared\tCubed" + "\n" +
                       "======\t=======\t=======");
                for (int p = 1; p <= i; p++) {
                    squared = (int)Math.Pow(p, 2);
                    cubed = (int)Math.Pow(p, 3);
                    Console.WriteLine(p + "\t" + squared + "\t" + cubed);
                    }

                Console.Write("Continue? (y/n)");
                choice = Console.ReadLine();

                }
            Console.WriteLine("Bye!");
            }
        }
    }
