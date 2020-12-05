using challenge_pig_dice.ui;
using System;

namespace challenge_pig_dice {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Pig Dice Game");

            // ask user how many games they want to play
            int numOfGames = MyConsole.getInt("How many games do you want to play: ");
            Console.WriteLine("You selected " + numOfGames + " game(s)");
            Console.WriteLine("Here we go...");
            int max = 0;
            // roll the dice
            for (int i = 0; i < numOfGames; i++) {
                int roll = 0;
                int total = 0;
                while (roll != 1) {
                    Random r = new Random();
                    roll = r.Next(1, 7);
                    total += roll;
                    }
                Console.WriteLine("Game #" + i + " score:" + total);
                max = Math.Max(max, total);
                roll = 0;
                total = 0;
                }
            Console.WriteLine("====================");
            Console.WriteLine("Total games:\t" + numOfGames);
            Console.WriteLine("Max Score:\t" + max);
            Console.WriteLine("====================");
        }
            
    }

}
    
