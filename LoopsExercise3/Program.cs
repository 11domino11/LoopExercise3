using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTo1000();
            Console.ReadLine();
            PrintBy3();
            Console.ReadLine();
            Console.WriteLine(IsEqual(2, 2));
            Console.ReadLine();
            Console.WriteLine(IsEven(100));
            Console.ReadLine();
            Console.WriteLine(IsPositive(-200));
            Console.ReadLine();
            Console.WriteLine(CanVote());
            Console.ReadLine();
            Console.WriteLine(InRange());
            Console.ReadLine();
            MultiplicationTable();
            Console.ReadLine();


        }
        static void PrintTo1000()
        {
            Console.WriteLine("1000 to -1000 by 1 \n");
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintBy3()
        {
            Console.WriteLine("Print by 3 to 999 \n");
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            } 
        }
       static string IsEqual(int x, int y)
        {
            if (x == y)
            {
                return "The two numbers ARE equal";
            }
            else return "The two numbers are NOT equal";
        }
        static string IsEven (int x)
        {
            if (x % 2 == 0)
            {
                return "The number is EVEN";
            }
            else return "The number is ODD";
        }
        static string IsPositive(int x)
        {
            if (x >= 0)
            {
                return "The number is POSITIVE";
            }
            else return "The number is NEGATIVE";
        }
        static string CanVote()
        {
            Console.WriteLine("Input your age");
            string ageText = Console.ReadLine();
            int age;
            bool isString = int.TryParse(ageText, out age);
            if (age >= 18)
            {
                return ($"You are {age} so you can vote!");
            }
            else return ($"You are {age} so you may NOT vote!");
        }
        static string InRange()
        {
            int x;
            Console.WriteLine("input a number for range test");
            string xString = Console.ReadLine();
            bool isString = int.TryParse(xString, out x);
            if (x >= -10 && x <= 10)
            {
                return $"{x} is within range";
            }
            else return $"{x} is NOT within range";
        }
        static void MultiplicationTable()
        {
            int x;
            Console.WriteLine("input a number for multiplication chart \n");
            string xString = Console.ReadLine();
            bool isString = int.TryParse(xString, out x);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * x);
            }
        }
    }
}
