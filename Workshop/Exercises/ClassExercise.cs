using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public static class ClassExercise
    {
        public static void One()
        {
            Animal dog = new Animal("Toby", "dog", "WoofWoof");
            Console.WriteLine(dog.name);
        }

        public static void Two()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal("Toby", "dog", "WoofWoof"),
                new Animal("Mieke", "cat", "MiauwMiauw"),
                new Animal("Nemo", "fish", "BlubBlub"),
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.name}: {animal.sound}");
            }
        }
    }
}
