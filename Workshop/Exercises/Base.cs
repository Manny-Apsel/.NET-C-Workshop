using System;

namespace Exercises
{
    public class Base
    {
        public static void beginningExercise(string title)
        {
            Console.WriteLine(title);
            for (int i = 0; i < title.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
