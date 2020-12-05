using System;

namespace ch11_arrays_demo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Let's do some arrays");

            String[] names = { "Chris", "Josh", "Derek", "Monroe" };
            Console.WriteLine("Element at position 1: " + names[1]);

            //indexed for loop
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
                }

            // for each loop
            foreach (string name in names) {
                Console.WriteLine(name);

                }

            Console.WriteLine("Bye");
            }
        }
    }
