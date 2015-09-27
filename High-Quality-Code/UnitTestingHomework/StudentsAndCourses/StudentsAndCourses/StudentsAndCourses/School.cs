namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private IList<Course> courses;
        private IList<Student> students;

        public School()
        {
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }

        public int StudentCount
        {
            get
            {
                return this.students.Count;
            }
        }

        public int CourseCount
        {
            get
            {
                return this.courses.Count;
            }
        }

        public School AddCourse(Course course)
        {
            this.courses.Add(course);

            return this;
        }

        public School AddStudent(Student student)
        {
            this.students.Add(student);

            return this;
        }

        public School RemoveCourse(Course course)
        {
            this.courses.Remove(course);

            return this;
        }

        public School RemoveStudent(Student student)
        {
            this.students.Remove(student);

            return this;
        }
    }
}
