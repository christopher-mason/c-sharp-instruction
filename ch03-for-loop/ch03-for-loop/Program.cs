using System;

namespace ch03_for_loop {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Creating for-loops");
            // indexed for loop that will print hello n times
            // n will be entered by user

            Console.Write("Enter a whole number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Hello! " + i);
                }


            }
        }
    }
