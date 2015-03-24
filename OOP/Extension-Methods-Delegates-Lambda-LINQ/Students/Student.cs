namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public static bool FirstBeforeLast(Student student)
        {
            if (student.FirstName.ToUpper()[0] < student.LastName.ToUpper()[0])
	        {
                return true;
	        }
            return false;
        }

        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();

            printer.Append(FirstName + " " + LastName);

            return printer.ToString();
        }

        public static bool InAgeRange(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
