namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : Person, ICommentable
    {
        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string comment)
            : base(name)
        {
            this.ClassNumber = classNumber;
            this.Comment = comment;
        }

        public int ClassNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Comment
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
