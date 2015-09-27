using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsAndCourses;

namespace TestStudentsAndCourses
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Student name cannot be empty.")]
        public void TestName_ThrowWhenEmpty()
        {
            var student = new Student("", 14000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Student ID cannot be below 10 000.")]
        public void TestId_ThrowWhenBelow10000()
        {
            var student = new Student("pesho", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Student ID cannot be above 99 999.")]
        public void TestId_ThrowWhenAbove99999()
        {
            var student = new Student("pesho", 100000);
        }
    }
}
