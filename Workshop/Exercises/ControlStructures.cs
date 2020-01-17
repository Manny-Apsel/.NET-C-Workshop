using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public static class ControlStructures
    {
        public static void exerciseOne()
        {
            Base.beginningExercise("Exercise one");
            int count = 0;
            Console.Write("How many numbers do you want to count: ");
            int length = int.Parse(Console.ReadLine());

            for (int i = 1; i <= length; i++)
            {
                count += i;
            }

            Console.WriteLine("Total count is: {0}",count);
        }

        public static void exerciseTwo()
        {
            Base.beginningExercise("Exercise two");
            bool keepGoing = true;

            do
            {
                Console.WriteLine("Which calculation do you want to perform?");
                Console.WriteLine("a. addition\nb. reduction\nc. multiplication\nd. division\ne. exit");
                Console.Write("Give your choice: ");
                string input = Console.ReadLine();
                if (input == "e")
                {
                    break;
                }
                Console.Write("First number: ");
                double numOne = int.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                double numTwo = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case "a":
                        Console.WriteLine($"Result: {numOne + numTwo}");
                        break;
                    case "b":
                        Console.WriteLine($"Result: {numOne - numTwo}");
                        break;
                    case "c":
                        Console.WriteLine($"Result: {numOne * numTwo}");
                        break;
                    case "d":
                        Console.WriteLine($"Result: {numOne / numTwo}");
                        break;
                }
                Console.WriteLine();
            } while (keepGoing == true);
        }
    }
}
