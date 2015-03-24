using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender sex)
            : base(name, age, sex)
        {
        }

        public override string MakeSound()
        {
            return "DJAF";
        }
    }
}
