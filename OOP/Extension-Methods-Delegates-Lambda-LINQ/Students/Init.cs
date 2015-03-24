namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Init
    {
        static void Main()
        {
            Student[] students = new Student[3];

            students[0] = new Student("Zohn", "Smith", 69);
            students[1] = new Student("Oprah", "Whinfrey", 21);
            students[2] = new Student("David", "Pecker", 37);

            //Problem 3. First before last
            Console.WriteLine(Environment.NewLine + "First name before last: " + Environment.NewLine);
            for (int i = 0; i < students.GetLength(0); i++)
            {
                if (Student.FirstBeforeLast(students[i]))
                {
                    Console.WriteLine(students[i]);
                }
            }


            //Problem 4. Age range
            Console.WriteLine(Environment.NewLine + "In age range: " + Environment.NewLine);
            var studentsInRange = from student in students
                                  where (student.Age >= 18 && student.Age <= 24)
                                  select student;
            foreach (var student in studentsInRange)
            {
                Console.WriteLine(student);
            }

            //Problem 5. Order students
            Console.WriteLine(Environment.NewLine + "Students ordered: " + Environment.NewLine);
            var studentsOrdered = students.OrderByDescending(x => x.FirstName[0]).ThenBy(x => x.LastName[0]);
            foreach (var student in studentsOrdered)
            {
                Console.WriteLine(student);
            }
        }
    }
}