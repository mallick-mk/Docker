using Xunit;
using myWebApp.Models;

namespace myWebApp.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Student_Constructor_Should_Set_Properties()
        {
            // Arrange
            int id = 1;
            string lastName = "Muhammad";
            string firstMidName = "Kashif";
            DateTime enrollmentDate = new DateTime(2024, 9, 19);
            //new DateTime(2013, 3, 15);

            // Act
            Student student = new Student
            {
                ID = id,
                LastName = lastName,
                FirstMidName = firstMidName,
                EnrollmentDate = enrollmentDate
            };

            // Assert
            Assert.Equal(id, student.ID);
            Assert.Equal(lastName, student.LastName);
            Assert.Equal(firstMidName, student.FirstMidName);
            Assert.Equal(enrollmentDate, student.EnrollmentDate);
        }
    }
}
