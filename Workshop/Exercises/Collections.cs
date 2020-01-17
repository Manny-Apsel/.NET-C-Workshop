using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public static class Collections
    {

        public static void exerciseOne()
        {
            Base.beginningExercise("Exercise one");
            List<string> names = new List<string>()
            {
                "Manny",
                "Stefan",
                "Rafah"
            };
            names.Add("");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            for (int i = 0; i<names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        public static void exerciseTwo()
        {
            Base.beginningExercise("Exercise two");
            double[] array1 = new double[10];
            double[] array2 = new double[10];
            double[] result = new double[10];

            Random rnd = new Random();

            for (int i = 0; i<array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 10);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 10);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] / array2[i];
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{array1[i]} / {array2[i]} = {result[i]}");
            }
        }

        public static void exerciseThree()
        {
            // stack goes with LIFO
            // queue goes with FIFO
        }
        
    }
}
