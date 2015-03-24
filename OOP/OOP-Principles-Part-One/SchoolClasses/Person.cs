using System;
namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                foreach (var letter in this.name)
                {
                    if (!Char.IsLetter(letter))
                    {
                        throw new ArgumentException("Invalid person name.");
                    }
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
