using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender sex)
            : base(name, age, sex)
        {
            this.Sex = Gender.Male;
        }

        public override string MakeSound()
        {
            return "RAWR";
        }
    }
}
