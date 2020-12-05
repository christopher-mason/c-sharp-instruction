using System;
using System.Collections.Generic;
using System.Text;

namespace ch07_product_manager.MyConsole {
    class MyConsole {

        public static String GetString(String prompt) {
            Console.Write(prompt);
            String s = Console.ReadLine();
            return s;
            }

        public static int GetInt(String prompt) {
            int n = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    n = int.Parse(Console.ReadLine());
                    success = true;
                    } catch (Exception e) {
                    Console.WriteLine("Invalid entry. Not a whole number. Try again.");
                    }
                }
            return n;
            }

        private static int GetInt(string prompt, int min, int max) {
            int i = 0;
            bool isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                try {
                    i = Int32.Parse(Console.ReadLine());
                    } catch (Exception e) {
                    Console.WriteLine("Invalid entry. Try again.");
                    }
                }
                //if (i <= min) {
                //    Console.WriteLine("Error! Number must be greater than " + min + ".");
                //} else if (i >= max) {
                //    Console.WriteLine("Error! Number must be las then " + max + ".");
                //} else {
                //    isValid = true;
                //}
                //}
            return i;
            }

        private static double GetDouble(String prompt) {
            double d = 0.0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    d = double.Parse(Console.ReadLine());
                    success = true;
                    } catch (Exception e) {
                    Console.WriteLine("Invalid entry. Try again.");
                    }
                }
            return d;
            }

        private static double GetDouble(string prompt, double min, double max) {
            double i = 0.0;
            Boolean isValid = false;
            while (!isValid) {
                i = GetInt(prompt);
                if (i <= min) {
                    Console.WriteLine("Error! Number must be greater than " + min + ".");
                    } else if (i >= max) {
                    Console.WriteLine("Error! Number must be las then " + max + ".");
                    } else {
                    isValid = true;
                    }
                }
            return i;
            }

        }
    }
