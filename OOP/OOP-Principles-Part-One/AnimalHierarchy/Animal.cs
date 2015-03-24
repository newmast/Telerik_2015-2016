using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Animal : ISound
    {
        private int age;
        private string name;
        private Gender sex;

        public Animal(string name, int age, Gender sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
    
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid value for name.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid age.");
                }
                this.age = value;
            }
        }

        public Gender Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, age: {1}, sex: {2}", this.name, this.age, this.sex);
        }

        public virtual string MakeSound()
        {
            return "...";
        }
    }
}
