using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //title 
            Console.WriteLine("CALCULATOR APPLICATION");

            //asking for the 1st number
            Console.Write("What is the first number?");
            double number1 = Convert.ToDouble(Console.ReadLine());

            //asking for 2nd number
            Console.Write("What is the second number?");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //Display the options the user can pick from 
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            //user picks their option
            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            //execute the users option 
            double result = 0;
            //bool validChoice = true;

            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine("The result of addition is: " + result);
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine("The result of subtraction is: " + result);
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine("The result of multiplication is: " + result);
                    break;
                case 4:
                    result = number1 / number2;
                    Console.WriteLine("The result of division is: " + result);
                    break;
            }
            // display final choice and result again
            Console.WriteLine("Here is the result: " + result);
        }
    }
}
