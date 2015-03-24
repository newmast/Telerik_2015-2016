using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender sex)
            : base(name, age, sex)
        {
        }

        public override string MakeSound()
        {
            return "MEOW";
        }
    }
}
