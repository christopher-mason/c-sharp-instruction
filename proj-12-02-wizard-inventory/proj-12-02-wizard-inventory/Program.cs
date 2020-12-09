using System;
using System.Collections.Generic;
using System.Collections;
using proj_12_02_wizard_inventory.ui;

namespace proj_12_02_wizard_inventory {
    class Program {
        //static final int MAX_INVENTORY_SIZE = 4;

        static void Main(string[] args) {
            Console.WriteLine("The Wizard Inventory game\n");
            DisplayMenu();

            List<String> inventory = new ArrayList<>();
            inventory.Add("wooden staff");
            inventory.Add("wizard hat");
            inventory.Add("cloth choes");

            String command = "go";

            while (!command.Equals("exit")) {
                command = MyConsole.getString("Command: ");

                switch (command) {
                    case "show":
                        ShowInventory(inventory);
                        break;
                    case "grab":
                        AddItemToInventory(inventory);
                        break;
                    case "edit":

                        break;
                    case "drop":

                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                    }
                }


            }

        private static void DisplayMenu() {
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine("show - Show all items");
            Console.WriteLine("grab - Grab an item");
            Console.WriteLine("edit - Edit an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("exit - Exit program");
            }

        private static void ShowInventory(List<string> inventory) {
            int oneBasedIndex = 1;

            foreach (String item in inventory) {
                Console.WriteLine(oneBasedIndex + "." + item);
                oneBasedIndex++;
                }
            }

        private static void AddItemToInventory(List<String> inventory) {
            if (inventory. >= 4) {
                Console.WriteLine("You can't carry any more items. Drop something first");
                return;
                }

            String newItem = MyConsole.getString("Name: ");
            inventory.Add(newItem);
            Console.WriteLine(newItem + " was added.");
            }

        }
    }
