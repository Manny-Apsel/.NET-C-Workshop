using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public static class Datatypes
    {
        public static void exerciseOne()
        {
            Base.beginningExercise("Exercise 1");
            int a = 4;
            int b = 2;
            int c = a + b;
            Console.WriteLine(c);
        }

        public static void exerciseTwo()
        {
            Base.beginningExercise("Exercise 2");
            string a = "Im the first string.";
            string b = " Im the second string.";
            Console.WriteLine(a+b);
        }

        public static void exerciseThree()
        {
            Base.beginningExercise("Exercise 3");
            char character = 'm';
            Console.WriteLine("My favorite charachter is '" + character + "' because it the first letter of my name.");
        }

        public static void exerciseFour()
        {
            Base.beginningExercise("Exercise 4");
            int factorial = Convert.ToInt32(2.658);
            ushort longestNumber = ushort.MaxValue;
            ushort longestNumberPlusOne;
            Console.WriteLine(factorial);
            Console.WriteLine(longestNumber);
        }
    }
}
