using System;
using System.Collections.Generic;

namespace ch12_list_and_dictionary {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Create a list and a dictionary");

            // a list
            List<double> prices = new List<double>();
            prices.Add(11.11);
            prices.Add(5.99);
            prices.Add(250.25);

            // get an element from the list
            Console.WriteLine(prices[1]);

            // old school for loop
            for (int i = 0; i < prices.Count; i++) {
                Console.WriteLine(prices[i]);
                }

            // for each
            foreach (double p in prices) {
                Console.WriteLine(p);
                }

            }
        }
    }
