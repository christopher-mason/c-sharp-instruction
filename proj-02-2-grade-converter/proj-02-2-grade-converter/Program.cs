﻿using System;

namespace proj_02_2_grade_converter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Letter Grade Converter");

            String letterGrade;

            do {
                Console.Write("\nEnter numerical grade: ");
                int numGrade = Int32.Parse(Console.ReadLine());

                if (numGrade <= 100 && numGrade >= 88) {
                    Console.WriteLine("Letter Grade: A");
                    } else if (numGrade <= 100 && numGrade >= 80) {
                    Console.WriteLine("Letter Grade: B");
                    } else if (numGrade <= 100 && numGrade >= 66) {
                    Console.WriteLine("Letter Grade: C");
                    } else if (numGrade <= 100 && numGrade >= 60) {
                    Console.WriteLine("Letter Grade: D");
                    } else if (numGrade < 60 && numGrade >= 0) {
                    Console.WriteLine("Letter Grade: F");
                    } else {
                    Console.WriteLine("Invalid number.");
                    }

                Console.Write("\nContinue? (y/n): ");
                letterGrade = Console.ReadLine();
                } 
                while (letterGrade.Equals("y") || letterGrade.Equals("Y"));
            }
        }
    }
