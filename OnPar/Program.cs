using System;
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

        }
    }
}
