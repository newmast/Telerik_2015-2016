namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class StudentExtensions
    {
        public static List<Student> ExtractStudentsWithGroupNumber(this List<Student> students, int groupNumber)
        {
            var resultingStudents = new List<Student>();

            foreach (var student in students)
            {
                if (student.Group.GroupNumber == groupNumber)
                {
                    resultingStudents.Add(student);
                }
            }
            return resultingStudents;
        }
        public static int GetTwosCount(this List<int> marks)
        {
            int count = 0;
            foreach (var mark in marks)
            {
                if (mark == 2)
                {
                    count++;
                }
            }
            return count;
        }
        public static List<string> SortByGroupNumber(this List<Student> students)
        {
            var groups = students.GroupBy(x => x.Group.GroupNumber);

            var result = new List<string>();
            foreach (var group in groups)
            {
                result.Add(String.Format("Group {0}: {1}",
                    group.ElementAt(0).Group.GroupNumber, String.Join(", ", group)));
            }
            return result;
        }
    }
}
 