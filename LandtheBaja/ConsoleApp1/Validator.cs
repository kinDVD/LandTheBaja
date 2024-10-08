﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticLecture
{
    public static class Validator
    {
        public static int GetInputInt()
        {
            int result = -1;
            while (int.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.WriteLine("Invalid input.");
            }
            return result;
        }

        public static int GetIntRange()
        {
            int result = -1;
            while (int.TryParse(Console.ReadLine(), out result) == false || result > 3)
            {
                Console.WriteLine("Invalid input.");
            }
            return result;
        }

        public static double GetInputDouble()
        {
            double result = -1;
            while (double.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.WriteLine("Invalid input.");
            }
            return result;
        }

        public static float GetInputFloat()
        {
            float result = -1;
            while (float.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.WriteLine("Invalid input.");
            }
            return result;
        }
        public static decimal GetInputDecimal()
        {
            decimal result = -1;
            while (decimal.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.WriteLine("Invalid input.");
            }
            return result;
        }
        public static int GetPositiveInputInt()
        {
            int result = -1;
            while (int.TryParse(Console.ReadLine(), out result) == false || result <= 0)
            {
                Console.WriteLine("Invalid input. Try again with a positive number.");
            }
            return result;
        }

        public static double GetPositiveInputDouble()
        {
            double result = -1;
            while (double.TryParse(Console.ReadLine(), out result) == false || result <= 0)
            {
                Console.WriteLine("Invalid input. Try again with a positive number.");
            }
            return result;
        }

        public static float GetPositiveInputFloat()
        {
            float result = -1;
            while (float.TryParse(Console.ReadLine(), out result) == false || result <= 0)
            {
                Console.WriteLine("Invalid input. Try again with a positive number.");
            }
            return result;
        }
        public static decimal GetPositiveInputDecimal()
        {
            decimal result = -1;
            while (decimal.TryParse(Console.ReadLine(), out result) == false || result <= 0)
            {
                Console.WriteLine("Invalid input. Try again with a positive number.");
            }
            return result;
        }

        public static bool GetContinue()
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine("Would you like to run again? y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return result;
        }

        public static bool GetContinue(string message)
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine($"{message} y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return result;
        }

        public static bool GetContinue(string message, string y, string n)
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine($"{message} {y}/{n}");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == y.ToLower())
                {
                    result = true;
                    break;
                }
                else if (choice == n.ToLower())
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return result;
        }
    }
}
