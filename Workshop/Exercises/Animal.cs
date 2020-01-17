using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class Animal
    {
        protected internal string name { get; set; }
        protected internal string species { get; set; }
        protected internal string sound { get; set; }

        protected internal Animal(string Name, string Species, string Sound)
        {
            this.name = Name;
            this.species = Species;
            this.sound = Sound;
        }

        protected internal Animal(string Name, string Species)
        {
            this.name = Name;
            this.species = Species;
        }
    }
}
