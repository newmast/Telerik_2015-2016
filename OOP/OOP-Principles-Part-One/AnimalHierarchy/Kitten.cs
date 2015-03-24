using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, Gender sex)
            : base(name, age, sex)
        {
            this.Sex = Gender.Female;
        }

        public override string MakeSound()
        {
            return "PRRR";
        }
    }
}
