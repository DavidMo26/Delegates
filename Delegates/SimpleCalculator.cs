using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    static class SimpleCalculator
    {
        public static int NumberGetter()
        {
            int number;
            do
            {
                Console.WriteLine("Please enter positive number : ");
                number = int.Parse(Console.ReadLine()); 

            } while (number < 0);
            return number;           
        }
        public static void PrintMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
        }
        public static int GetUserChoice()
        {
            int num;
            do
            {
                Console.WriteLine("Please enter number between 1-4 : ");
                num = int.Parse(Console.ReadLine());

            } while (num <= 1 && num >= 4);
            return num;
        }
        public static double Calculate(int n1,int n2,int oper)
        {
            if (oper == 1) return (n1 + n2);
            if (oper == 2) return (n1 - n2);
            if (oper == 3) return (n1 * n2);
            else return (n1 / n2);
        }
        public static void PrintResultNicely(double result)
        {
            Console.WriteLine($"\n********Result is : {result} ***********");
        }
    }
}
