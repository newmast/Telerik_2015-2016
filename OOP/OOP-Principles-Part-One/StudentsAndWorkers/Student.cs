﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            :base(firstName, lastName)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " - Grade: " + this.grade;
        }
    }
}
