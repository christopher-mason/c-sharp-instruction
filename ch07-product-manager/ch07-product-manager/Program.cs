using ch07_product_manager.business;
using ch07_product_manager.util;
using System;

namespace ch07_product_manager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager");

            Product p1 = new Product();
            p1.code = ".net";
            p1.description = "Murach's C# and .NET";
            p1.price = 58.99;
            Console.WriteLine("p1= " + p1);

            Product p2 = new Product("java", "Murach's Java Programming", 59.50);
            Console.WriteLine($"p2 = {p2}");

            String str = MyConsole.getString("enter a string");
            

            Console.WriteLine("Bye!");

            }
        }
    }
