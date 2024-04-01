    using System;
    using System.Collections.Generic;

    using NUnit.Framework;

    namespace TestApp.Tests;

    [TestFixture]
    public class GradesTests
    {
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> student = new Dictionary<string, int>
        {
            ["Tosho"] = 3,
            ["Gosho"] = 4,
            ["Ina"] = 5,
            ["Asen"] = 4,
            ["Stefi"] = 6,
        };

            // Act
            string result = Grades.GetBestStudents(student);

            // Assert
            Assert.That(result, Is.EqualTo($"Stefi with average grade 6.00{Environment.NewLine}Ina with average grade 5.00{Environment.NewLine}Asen with average grade 4.00"));
        }

        [Test]
        public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
        {
            // Arrange
            Dictionary<string, int> student = new Dictionary<string, int>();

            // Act
            string result = Grades.GetBestStudents(student);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
        {
            // Arrange
            Dictionary<string, int> student = new Dictionary<string, int>
            { 
                ["Tosho"] = 5,
                ["Gosho"] = 2
            };

            // Act
            string result = Grades.GetBestStudents(student);

            // Assert
            Assert.That(result, Is.EqualTo($"Tosho with average grade 5.00{Environment.NewLine}Gosho with average grade 2.00"));
        }

        [Test]
        public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
        {
            // Arrange
            Dictionary<string, int> student = new Dictionary<string, int>
            {
                ["Tosho"] = 5,
                ["Gosho"] = 6,
                ["Ina"] = 6,
                ["Stefi"] = 6
            };


            // Act
            string result = Grades.GetBestStudents(student);

            // Assert
            Assert.That(result, Is.EqualTo($"Gosho with average grade 6.00{Environment.NewLine}Ina with average grade 6.00{Environment.NewLine}Stefi with average grade 6.00"));
        }
    }
