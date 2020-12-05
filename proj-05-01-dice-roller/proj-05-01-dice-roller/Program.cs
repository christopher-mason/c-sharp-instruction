using System;

namespace proj_05_01_dice_roller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dice Roller");

            int dice1 = GetDiceRoll();
            int dice2 = GetDiceRoll();

            String message = "Dice 1: " + dice1 + "\n" + "Dice 2: " + dice2 + "\n" + "Total: " + (dice1 + dice2);
            Console.WriteLine(message);
            PrintExtraMessage(dice1, dice2);

            }

        static int GetDiceRoll() {
            Random rnd = new Random();
            int diceRoll = rnd.Next(1, 7);
            return diceRoll;

            }
        static void PrintExtraMessage(int dice1, int dice2) {
            if (dice1 + dice2 == 2) {
                Console.WriteLine("Snake Eyes");
                } else if (dice1 + dice2 == 12) {
                Console.WriteLine("Box cars!");
                } 
            }
        }
    }
