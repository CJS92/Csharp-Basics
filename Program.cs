// This program was created for a project in IT 2040.
// Cody Sloan
// 02/07/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and constants
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            const float acceleration = 9.800f;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";
            float mass = 14.6f;
            int heartRate = 85;
            int choice = 2;
            double deposits = 135002796;
            double distance = 129.763001;
            double force = mass * acceleration;
            bool lost = true;
            bool expensive = true;

            // check if sample1 and sample2 are equal
            if (sample1 == sample2)
            {
                // if so, print the following line
                Console.WriteLine("The samples are equal.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }
            else
            {
                // otherwise print this line
                Console.WriteLine("The samples are not equal.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }

            // check heart rate
            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }

            // check the deposits
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }

            // display force
            {
                Console.WriteLine("Force = {0:0.000}", force);
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }

            // display the value of distance
            {
                Console.WriteLine("{0} is the distance.", distance);
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }

            // check the values of lost and expensive and display a message if both are true
            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }
            else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is a coupon for 10% off.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }

            // Switch/Case for the choice variable
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose {0}.", choice);
                    break;
                case 2:
                    Console.WriteLine("You chose {0}.", choice);
                    break;
                case 3:
                    Console.WriteLine("You chose {0}.", choice);
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();

            // display integral value
            {
                // Print the actual value of the char variable
                Console.Write((int)integral);
                Console.WriteLine(" is an integral.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.WriteLine("-----------------------------");
                Console.ReadLine();
            }

            // begin loop
            for (int age = 0; age < 6; age = age + 1)
            {
                Console.WriteLine("age = {0}", age);
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();

            // display greeting message
            {
                Console.Write(greeting);
                Console.Write(" ");
                Console.Write(name);
                Console.WriteLine("\n\nPress Enter to exit...");
                Console.ReadLine();
          }
        }
      } 
   }