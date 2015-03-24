namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Init
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var students = new List<Student>();
            students.Add(new Student("Petar", "Petrov", "123456789", "0845214252",
                    "petar.petrov@mail.bg", new List<int> { 2, 5, 5, 6}, new Group(1, "Mathemathics")));
            students.Add(new Student("Gosho", "Dimitrov", "123200612", "084865752",
                    "gosho.dimitrov@abv.bg", new List<int> { 5, 6, 5, 3 }, new Group(2, "Mathemathics")));
            students.Add(new Student("Dimitar", "Evgeniev", "978200615", "0854365325",
                    "dimitar.evgeniev@gmail.bg", new List<int> { 2, 2, 4, 5 }, new Group(3, "Physics")));

            //Problem 9. Student groups
            var groupTwo = PrintGroupTwoStudentsLINQ(students);

            WaitForInput();
            //Problem 10. Student groups extensions
            groupTwo = PrintGroupTwoStudentsExtensions(students, groupTwo);

            WaitForInput();
            //Problem 11. Extract students by email
            PrintAbvMailStudents(students, groupTwo);

            WaitForInput();
            //Problem 12. Extract students by phone
            PrintSofiaNumberStudents(students, groupTwo);

            WaitForInput();
            //Problem 13. Extract students by marks
            PrintBestStudents(students);

            WaitForInput();
            //Problem 14. Extract students with two marks
            PrintStudentsWithTwoFs(students);

            WaitForInput();
            //Problem 15. Extract marks
            Print2006Students(students);

            WaitForInput();
            //Problem 16.* Groups
            PrintMathemathicsGroup(students);

            WaitForInput();
            //Problem 18. Grouped by GroupNumber
            PrintGroupByGroupNameLinq(students);

            WaitForInput();
            //Problem 19. Grouped by GroupName extensions
            PrintGroupByGroupNameExtensions(students);

        }

        private static void WaitForInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to continue...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        private static IEnumerable<Student> PrintGroupTwoStudentsLINQ(List<Student> students)
        {
            var groupTwo = from student in students
                           where (student.Group.GroupNumber == 2)
                           select student;

            groupTwo = groupTwo.OrderBy(x => x.FirstName);
            Console.WriteLine("Students from group 2, sorted by first name with LINQ: ");

            foreach (var student in groupTwo)
            {
                Console.WriteLine(student);
            }
            return groupTwo;
        }

        private static IEnumerable<Student> PrintGroupTwoStudentsExtensions(List<Student> students, IEnumerable<Student> groupTwo)
        {
            groupTwo = students.ExtractStudentsWithGroupNumber(2);
            Console.WriteLine("Students from group 2, sorted by first name with extensions: ");

            foreach (var student in groupTwo)
            {
                Console.WriteLine(student);
            }
            return groupTwo;
        }

        private static void PrintAbvMailStudents(List<Student> students, IEnumerable<Student> groupTwo)
        {
            var abvEmail = from student in students
                           where (student.Email.Contains("@abv.bg"))
                           select students;

            Console.WriteLine("Students with abv email: ");
            foreach (var student in groupTwo)
            {
                Console.WriteLine(student);
            }
        }

        private static void PrintSofiaNumberStudents(List<Student> students, IEnumerable<Student> groupTwo)
        {
            var sofiaNumber = from student in students
                              where (student.Tel[0] == '0' && student.Tel[1] == '2')
                              select student;

            Console.WriteLine("Students with numbers from Sofia: ");
            foreach (var student in groupTwo)
            {
                Console.WriteLine(student);
            }
        }

        private static void PrintBestStudents(List<Student> students)
        {
            var bestStudents = from student in students
                               where (student.Marks.Contains(6))
                               select new
                               {
                                   FullName = student.FirstName + " " + student.LastName,
                                   Marks = student.Marks
                               };
            Console.WriteLine("Students with excellence:");

            foreach (var student in bestStudents)
            {
                Console.WriteLine(student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintStudentsWithTwoFs(List<Student> students)
        {
            var worstStudents = from student in students
                                where (student.Marks.GetTwosCount() == 2)
                                select new
                                {
                                    FullName = student.FirstName + " " + student.LastName,
                                    Marks = student.Marks
                                };
            Console.WriteLine("Students with two marks \"2\":");

            foreach (var student in worstStudents)
            {
                Console.WriteLine(student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Print2006Students(List<Student> students)
        {
            var gradYear2006 = from student in students
                               where (student.FN[5] == '0' && student.FN[6] == '6')
                               select new
                               {
                                   FullName = student.FirstName + " " + student.LastName,
                                   Marks = student.Marks
                               };
            Console.WriteLine("Students that enrolled in 2006:");

            foreach (var student in gradYear2006)
            {
                Console.WriteLine(student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintMathemathicsGroup(List<Student> students)
        {

            var studentsInMathemathics = from student in students
                                         where (student.Group.DepartmentName == "Mathemathics")
                                         select new
                                         {
                                             FullName = student.FirstName + " " + student.LastName,
                                             Marks = student.Marks
                                         };
            Console.WriteLine("Students that are part of the Mathemathics department:");

            foreach (var student in studentsInMathemathics)
            {
                Console.WriteLine(student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintGroupByGroupNameLinq(List<Student> students)
        {
            Console.WriteLine("Groups by Group name with LINQ: ");
            var groupsLinq = from student in students
                             group student by student.Group.GroupNumber;

            foreach (var group in groupsLinq)
            {
                Console.WriteLine("Group " + group.ElementAt(0).Group.GroupNumber + ": " + string.Join(", ", group));
            }
        }

        private static void PrintGroupByGroupNameExtensions(List<Student> students)
        {
            Console.WriteLine("Groups by Group name with lambda: ");
            var groupLambda = students.SortByGroupNumber();

            foreach (var group in groupLambda)
            {
                Console.WriteLine(group);
            }
        }
    }
}
