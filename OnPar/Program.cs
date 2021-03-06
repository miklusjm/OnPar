﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnPar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = true;
            while (go == true)
            {
                Console.Clear();
                Console.WriteLine("OnPar Challenge!");
                Console.WriteLine("July 21, 2016\n");
                Console.WriteLine("*******************************\n");
                Console.WriteLine("1. Problem One (Integer Sums)");
                Console.WriteLine("2. Problem Two (Calculator)");
                Console.WriteLine("3. Quit\n");
                Console.Write("Enter the number for your selection: ");
                string control = Console.ReadLine();

                if (control == "1")
                {
                    IntegerSum();
                }
                else if (control == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Try the ^ operator for exponents in the form X ^ Y.");
                    Console.WriteLine("Try the r operator for roots in the form Xth root of Y.");
                    Console.WriteLine("Neither of the above features are guaranteed for all use cases.");
                    Console.WriteLine();
                    Console.WriteLine("Hit Enter to continue.");
                    Console.ReadKey();
                    Calculator();
                }
                else if (control == "3")
                {
                    go = false;
                }
                else
                {
                    Console.WriteLine("\nInvalid selection. Hit any key to continue.");
                    Console.ReadKey();
                }

            }

        }

        static void IntegerSum()
        {
            List<int> numbers = new List<int>();

            bool loop = true;

            while (loop == true)
            {
                Console.Clear();
                Console.Write("Enter a number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
                Console.Clear();

                int sum = 0;

                for(int x = 0; x < numbers.Count; x++)
                {
                    //Absolute value for neater +/- output
                    Console.Write(Math.Abs(numbers[x]));
                    if (x < numbers.Count - 1 && numbers[x+1] >= 0)
                    {
                        Console.Write(" + ");
                    }
                    else if (x < numbers.Count - 1 && numbers[x+1] < 0)
                    {
                        Console.Write(" - ");
                    }

                    sum += numbers[x];
                }

                Console.Write(" = " + sum + "\n\n");

                bool contLoop = true;

                while (contLoop == true)
                {
                    Console.Write("Continue? (YES/NO): ");
                    string cont = (Console.ReadLine().ToLower());
                    if (cont == "yes")
                    {
                        contLoop = false;
                    }
                    else if (cont == "no")
                    {
                        contLoop = false;
                        loop = false;
                        Console.Clear();
                        Console.WriteLine("GOODBYE...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid response.\n\n");
                    }
                }
            }


        }

        static void Calculator()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.Clear();
                Console.Write("Enter the first number: ");
                double firstNum = double.Parse(Console.ReadLine());
                Console.Write("Enter the operator: ");
                string op = Console.ReadLine();
                Console.Write("Enter the second number: ");
                double secondNum = double.Parse(Console.ReadLine());
                Console.Clear();
                if (op == "+")
                {
                    Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                }
                else if (op == "-")
                {
                    Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                }
                else if (op == "*")
                {
                    Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                }
                else if (op == "/")
                {
                    Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                }
                else if (op == "^")
                {
                    double expo = 1;
                    if (secondNum < 0)
                    {
                        Console.WriteLine("Second number can't be negative for exponents!");
                    }
                    else
                    {
                        for (int x = 0; x < secondNum; x++)
                        {
                            expo *= firstNum;
                        }
                        Console.WriteLine($"{firstNum} ^ {secondNum} = {expo}");
                    }
                }
                else if (op == "r")
                {
                    double check = 1;
                    double last = 2;
                    //max 20 iterations or
                    for (int x = 1; x <= 50 && Math.Abs(last - check) > .000001; x++)
                    {
                        last = check;
                        double lastExp = 1;
                        for (int y = 0; y < firstNum - 1; y++)
                        {
                            lastExp *= last;
                        }
                        check = (1 / firstNum) * ((firstNum - 1) * last + (secondNum / lastExp));
                    }
                    Console.WriteLine($"The {firstNum}th root of {secondNum} is {check}.");
                }
                else
                {
                    Console.WriteLine("Invalid operator.");
                }

                bool contLoop = true;
                while (contLoop == true)
                {
                    Console.Write("\n\nDo another calculation? (YES/NO): ");
                    string cont = Console.ReadLine().ToLower();
                    if (cont == "yes")
                    {
                        contLoop = false;
                    }
                    else if (cont == "no")
                    {
                        contLoop = false;
                        loop = false;
                        Console.Clear();
                        Console.WriteLine("GOODBYE...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid response.\n\n");
                    }

                }
            }

        }
    }
}
