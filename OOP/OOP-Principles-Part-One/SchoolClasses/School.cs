namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class School
    {
        private List<StudentClass> studentClasses;

        public School(List<StudentClass> studentClass)
        {
            this.studentClasses = studentClass;
        }
        public List<StudentClass> StudentClasses
        {
            get
            {
                if (this.studentClasses.Count == 0)
                {
                    throw new ArgumentException("There are no classes available.");
                }
                return this.studentClasses;
            }
            set
            {
                if (this.studentClasses.Count == 0)
                {
                    throw new ArgumentException("Invalid class count.");
                }
                this.studentClasses = value;
            }
        }
        public override string ToString()
        {
            return StudentClasses.ToString();
        }
    }
}
