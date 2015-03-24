namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Speciality Speciality { get; set; }

        public Student(string firstName, string middleName, string lastName, ulong ssn, string address, string phone, 
                       string email, int course, University uni, Faculty faculty, Speciality spec)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.University = uni;
            this.Faculty = faculty;
            this.Speciality = spec;
        }

        public override bool Equals(object obj)
        {
            if (this.FirstName == (obj as Student).FirstName &&
                this.MiddleName == (obj as Student).MiddleName &&
                this.LastName == (obj as Student).LastName &&
                this.SSN == (obj as Student).SSN &&
                this.Address == (obj as Student).Address &&
                this.Phone == (obj as Student).Phone &&
                this.Email == (obj as Student).Email &&
                this.Course == (obj as Student).Course &&
                this.University == (obj as Student).University &&
                this.Faculty == (obj as Student).Faculty &&
                this.Speciality == (obj as Student).Speciality)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Student one, Student two)
        {
            return one.Equals(two);
        }

        public static bool operator !=(Student one, Student two)
        {
            return !(one.Equals(two));
        }

        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();

            printer.Append(this.FirstName + " ");
            printer.Append(this.MiddleName + " ");
            printer.Append(this.LastName);
            printer.AppendLine(this.SSN.ToString());
            printer.AppendLine(this.Address);
            printer.AppendLine(this.Phone);
            printer.AppendLine(this.Email);
            printer.AppendLine(this.Course.ToString());
            printer.AppendLine(this.University.ToString());
            printer.AppendLine(this.Faculty.ToString());
            printer.AppendLine(this.Speciality.ToString());

            return printer.ToString();
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.Phone.GetHashCode();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
                this.Phone, this.Email, this.Course, this.University, this.Faculty, this.Speciality);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            else if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else if (this.SSN.CompareTo(other.SSN) != 0)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return 0;

        }
    }
}
