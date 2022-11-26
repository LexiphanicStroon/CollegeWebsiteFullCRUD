using System.ComponentModel;

namespace Register.Models
{
    public class Course
    {
        //CourseId, Course Number, Course Name, and Description 
        [DisplayName("Course ID")]
        public int Id { get; set; }
        [DisplayName("Course Number")]
        public int CourseNumber { get; set; }
        [DisplayName("Course Name")]
        public string Name { get; set; }
        [DisplayName("Course Description")]
        public string? Description { get; set; }
    }
}
