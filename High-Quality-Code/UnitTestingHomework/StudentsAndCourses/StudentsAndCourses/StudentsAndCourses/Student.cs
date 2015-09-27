namespace StudentsAndCourses
{
    using System;

    public class Student
    {
        private const int MinID = 10000;
        private const int MaxID = 99999;

        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < MinID || value > MaxID)
                {
                    throw new ArgumentException("Id out of bounds.");
                }

                this.id = value;
            }
        }

    }
}