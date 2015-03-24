namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public Group Group { get; set; }

        public Student(string firstName, string lastName, string FN, string tel, string email, List<int> marks, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = FN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.Group = group;
        }

        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();

            printer.AppendLine(this.FirstName + " " + this.LastName);
            printer.Append("Marks: ");
            foreach (var mark in this.Marks)
            {
                printer.Append(mark + " ");
            }
            printer.Append(Environment.NewLine);
            return printer.ToString();
        }
    }
}
