using System;

namespace proj_02_01_student_registration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Student Registration Form");

            Console.Write("Enter First Name: ");
            String firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            String lastName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            String tempPWD = firstName + "*" + year;

            Console.WriteLine("Welcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration is complete!");
            Console.WriteLine("Your temporary password is: " + tempPWD);

            }
        }
    }
