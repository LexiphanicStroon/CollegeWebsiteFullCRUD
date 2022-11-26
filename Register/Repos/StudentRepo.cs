using Register.Models;

namespace Register.Repos
{
    public class StudentRepo
    {
        //StudentId, First Name, Last Name, Email address, and Phone number.

        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Email = "studentOne@gmail.com", FirstName = "Nate", LastName = "Reeves", PhoneNumber = "241-314-5123"},
            new Student { Id = 2, Email = "studentTwo@gmail.com", FirstName = "Kyle", LastName = "Paisley", PhoneNumber = "123-456-1234"}
        };

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
