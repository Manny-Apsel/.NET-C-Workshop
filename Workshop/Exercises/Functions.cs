using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public static class Functions
    {
        public static void exerciseOne()
        {
            Base.beginningExercise("Exercise one");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            displayName(name);
        }

        private static void displayName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        public static void exerciseTwo()
        {
            Base.beginningExercise("Exercise two");
            Console.WriteLine("Give 3 numbers:");
            Console.Write("Number 1: ");
            var one = Convert.ToInt32(Console.ReadLine());
            // var one = (int)Console.ReadLine();
            Console.Write("Number 2: ");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            int three = int.Parse(Console.ReadLine());
            Console.WriteLine($"{one} x {two} x {three} = {multiplication(one, two, three)}");
        }

        private static object multiplication(int one, int two, int three)
        {
            return one * two * three;
        }

        public static void exerciseThree()
        {
            Base.beginningExercise("Exercise three");
            Console.Write("What's your input: ");
            var input = Console.ReadLine();
            whichFunctionWillBeTriggered(input);
        }

        private static void whichFunctionWillBeTriggered(string input)
        {
            Console.WriteLine($"This was your string: {input}");
        }
        private static void whichFunctionWillBeTriggered(int input)
        {
            Console.WriteLine($"This was your number: {input}");
        }
    }
}
