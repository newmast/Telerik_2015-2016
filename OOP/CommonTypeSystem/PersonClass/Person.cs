namespace PersonClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;
        private uint? age;

        public Person(string name, uint? age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public uint? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            return this.age == null ?
                string.Format("Name: " + this.name + Environment.NewLine + "Age: Age not specified.") :
                string.Format("Name: " + this.name + Environment.NewLine + "Age: " + this.age);
        }
    }
}
