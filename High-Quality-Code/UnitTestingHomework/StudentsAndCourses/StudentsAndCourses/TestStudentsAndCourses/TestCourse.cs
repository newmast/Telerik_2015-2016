using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsAndCourses;

namespace TestStudentsAndCourses
{
    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Added student cannot be null!")]
        public void TestAddStudent_ThrowWhenAddingNull()
        {
            var highQualityCode = new Course();
            Student pesho = null;
            highQualityCode.AddStudent(pesho);
        }

        [TestMethod]
        public void TestAddStudent()
        {
            var highQualityCode = new Course();
            var pesho = new Student("pesho", 14000);
            highQualityCode.AddStudent(pesho);

            Assert.AreEqual(1, highQualityCode.StudentCount, "Student can't be added to course.");
        }

        [TestMethod]
        public void TestRemoveStudent()
        {
            var jsBasics = new Course();
            var mozart = new Student("geri-nikol", 14000);

            jsBasics.AddStudent(mozart);
            jsBasics.RemoveStudent(mozart);

            Assert.AreEqual(0, jsBasics.StudentCount, "Student can't be removed from course");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Course doesn't have a student limit.")]
        public void TestAddStudent_ThrowWhenCourseIsFull()
        {
            var highQualityCode = new Course();

            for (int i = 0; i < Course.StudentLimit + 1; i++)
            {
                highQualityCode.AddStudent(new Student("DOMcho", 14000));
            }
        }
    }
}
