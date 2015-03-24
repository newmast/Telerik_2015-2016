//Problem 2. Students and workers

//Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace StudentsAndWorkers
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
            //Initialize 10 students
            var random = new Random();
            var students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                int grade = random.Next(2, 7);
                students.Add(new Student("Petar", Convert.ToString(i + 1), grade));
                Console.WriteLine(students[i]);
            }
            //Inialize 10 workers;
            var workers = new List<Worker>();
            for (int i = 0; i < 10; i++)
            {
                workers.Add(new Worker("Tom", Convert.ToString(i + 1), (i + 1) * 50, i + 3));
                Console.WriteLine(workers[i]);
            }
            //Sort students by grade /ascending order/
            var sortedStudentsByGrade = students.OrderBy(x => x.Grade);

            //Sort workers by hourly wage /descending order/
            var sortedWorkersByHourlyWage = workers.OrderBy(x => x.MoneyPerHour());

            var mergedGroups = new List<Human>();

            mergedGroups.AddRange(students);
            mergedGroups.AddRange(workers);

            mergedGroups = mergedGroups.OrderBy(x => x.FirstName)
                                       .ThenBy(x => x.LastName)
                                       .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, mergedGroups.Select(x => string.Format("{0} {1}", x.FirstName, x.LastName))));
        }
    }
}
