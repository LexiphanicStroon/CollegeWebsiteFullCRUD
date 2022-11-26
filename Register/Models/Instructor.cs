using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Register.Models
{
    public class Instructor
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set;}
        [DisplayName("Email Address")]
        public string? Email { get; set; }
        [DisplayName("Course Taught")]
        public string? CourseTaught { get; set; }
    }
}
