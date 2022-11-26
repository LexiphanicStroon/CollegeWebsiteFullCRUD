using System.Collections.Generic;
using System.ComponentModel;

namespace Register.Models
{
    public class Student
    {
        //StudentId, First Name, Last Name, Email address, and Phone number.
        [DisplayName("Student ID")]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [DisplayName("Student email")]
        public string? Email { get; set; }
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }
    }
}
