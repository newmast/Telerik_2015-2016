namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StudentClass : ICommentable
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string identifier;
        private string comment;

        public StudentClass(List<Student> students, List<Teacher> teachers, string identifier)
        {
            this.students = students;
            this.teachers = teachers;
            this.identifier = identifier;
        }

        public StudentClass(List<Student> students, List<Teacher> teachers, string identifier, string comment)
        {
            this.students = students;
            this.teachers = teachers;
            this.comment = comment;
            this.identifier = identifier;
        }

        public List<Student> Students
        {
            get
            {
                return this.Students;
            }
            set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(identifier))
                {
                    throw new ArgumentException("Invalid indentifier.");
                }
                this.identifier = value;
            }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(comment))
                {
                    return "No comment yet.";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return this.identifier;
        }
    }
}
