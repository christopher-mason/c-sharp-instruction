using challenge_make_chocolate.ui;
using System;

namespace challenge_make_chocolate {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Make Chocolate");

			String choice = "y";
			while (choice.Equals("y")) {
				int small = MyConsole.getInt("How many small bars of chocolate do you have? ");
				int big = MyConsole.getInt("How many big bars of chocolate do you have? ");
				int goal = MyConsole.getInt("How many kilos of chocolate do you want to make? ");

				int result = makeChocolate(small, big, goal);
				Console.WriteLine("Number of small bars to use: " + result);

				Console.WriteLine("Continue? (y/n)");
				choice = Console.ReadLine();
				

				}
				Console.WriteLine("Bye!");

			}

		public static int makeChocolate(int small, int big, int goal) {
			int result = goal % 5;

			if (small + big * 5 < goal) {
				return -1;
				} else if (small + big * 5 == goal) {
				return small;
				}
			return result;
		}

	}
}
    
