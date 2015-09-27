namespace StudentsAndCourses
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Course
    {
        public const int StudentLimit = 30;

        private IList<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public int StudentCount
        {
            get
            {
                return this.students.Count;
            }
        }

        public Course AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.StudentCount >= Course.StudentLimit)
            {
                throw new ArgumentException("Course is full");
            }

            this.students.Add(student);

            return this;
        }

        public Course RemoveStudent(Student student)
        {
            this.students.Remove(student);

            return this;
        }
    }
}
