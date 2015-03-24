namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        static void Main()
        {
            //Create school
            School mySchool = new School(
                new List<StudentClass> {
                    new StudentClass (
                        new List<Student> {
                            new Student("Peter", 1), 
                            new Student("Jason", 2),
                            new Student("Dufenshmurtz", 5) },
                        new List<Teacher> {
                            new Teacher("Dimitrova", new List<Discipline> { 
                                new Discipline("Elements", 42, 69), 
                                new Discipline("Math", 1, 100000)} ),
                            new Teacher("Ivanova", new List<Discipline> { 
                                new Discipline("English", 82, 29), 
                                new Discipline("Biology", 5, 4)
                            })
                        },
                        "Grade 10-A")
                }
            );
            //EXAMLE (ADDING A NEW TEACHER):
            //Create new teacher
            mySchool.StudentClasses[0].Teachers.Add(new Teacher("Stefanova", new List<Discipline> { new Discipline("Chemisty", 1, 2) }));
            //Print all teachers from StudentClass[0]
            foreach (var teacher in mySchool.StudentClasses[0].Teachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }
}