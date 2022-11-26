using Register.Models;
namespace Register.Repos
{
    public class InstructorRepo
    {
        private static List<Instructor> _instructors = new List<Instructor>
        {
            new Instructor { Id = 1, CourseTaught = "Math", Email = "teacherOne@gmail.com", FirstName = "John", LastName = "Smith"},
            new Instructor { Id = 2, CourseTaught = "Science", Email = "teacherTwo@gmail.com", FirstName = "Jane", LastName = "Doe"},
            new Instructor { Id = 3, CourseTaught = "ASP.NET Core", Email = "MikeZorin@gmail.com", FirstName = "Mike", LastName = "Zorin"}
        };
    
        public IEnumerable<Instructor> GetInstructors()
        {
            return _instructors;
        }

    }
}
