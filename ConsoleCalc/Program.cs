﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ParsingCalculator parser = new ParsingCalculator();
            string input;
            double output;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the expression (press 'q' for exit):");
                input = Console.ReadLine();
                input = RemoveSpaces(input);
                input = ReplaseDotsWithСomma(input);
                if (input[0] == 'q')
                    Environment.Exit(0);
                try
                {
                    output = parser.CountExpressionFromString(input);
                    Console.WriteLine("\nAnswer is " + output + ".");
                }
                catch (SyntaxException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArithmeticException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                Console.Write("\nPress any key to continue... ");
                Console.ReadLine();
            }
        }
        private static string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }

        private static string ReplaseDotsWithСomma(string input)
        {
            return input.Replace(".", ",");
        }
    }
}
