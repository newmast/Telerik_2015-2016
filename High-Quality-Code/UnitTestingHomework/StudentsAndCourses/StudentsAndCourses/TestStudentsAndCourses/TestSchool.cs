using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsAndCourses;

namespace TestStudentsAndCourses
{
    
    [TestClass]
    public class TestSchool
    {

        [TestMethod]
        public void TestAddStudent()
        {
            var TelerikAcademy = new School();
            var pesho = new Student("pesho", 14000);

            TelerikAcademy.AddStudent(pesho);

            Assert.AreEqual(1, TelerikAcademy.StudentCount, "Students can't be added to school.");
        }

        [TestMethod]
        public void TestAddCourse()
        {
            var TelerikAcademy = new School();
            var highQualityCode = new Course();

            TelerikAcademy.AddCourse(highQualityCode);

            Assert.AreEqual(1, TelerikAcademy.CourseCount, "Courses can't be added to school.");
        }

        [TestMethod]
        public void TestRemoveStudent()
        {
            var TelerikAcademy = new School();
            var pesho = new Student("pesho", 14000);

            TelerikAcademy.AddStudent(pesho);
            TelerikAcademy.RemoveStudent(pesho);

            Assert.AreEqual(0, TelerikAcademy.StudentCount, "Students can't be removed from school.");
        }

        [TestMethod]
        public void TestRemoveCourse()
        {
            var TelerikAcademy = new School();
            var CSharp = new Course();

            TelerikAcademy.AddCourse(CSharp);
            TelerikAcademy.RemoveCourse(CSharp);

            Assert.AreEqual(0, TelerikAcademy.CourseCount, "Courses can't be removed from school.");
        }
    }
}
