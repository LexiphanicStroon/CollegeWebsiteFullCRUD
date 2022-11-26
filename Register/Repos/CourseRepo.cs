using Register.Models;
namespace Register.Repos
{
    public class CourseRepo
    {
        private static List<Course> _courses = new List<Course>
        {
            new Course { Id = 1, CourseNumber = 1, Description = "Computer Science Concepts", Name = "FSD"},
            new Course { Id = 2, CourseNumber = 2, Description = "Learn better Greek and discover the true value of life in your own “Ithaka", Name = "Greek Poetry"}
        };

        public IEnumerable<Course> GetCourses()
        {
            return _courses;
        }
        
    }
}
