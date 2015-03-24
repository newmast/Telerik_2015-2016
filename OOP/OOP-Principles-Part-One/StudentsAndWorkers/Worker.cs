using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
    
        public int WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public float MoneyPerHour()
        {
            return this.weekSalary / (7 * this.workHoursPerDay);
        }

        public override string ToString()
        {
            return base.ToString() + "   " +
                "Salary: " + this.weekSalary + "   " +
                "Work hours / day: " + this.workHoursPerDay + "   " +
                "Money / hour: " + this.MoneyPerHour();
        }
    }
}
