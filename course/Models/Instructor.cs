using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace course.Models
{
    public class Instructor
    {
        [Key]
        [DisplayName("Id")]
        public int InstructorId { get; set; }
        [DisplayName("First Name")]
        public string FirstName {  get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Email")]
        public string EmailAddress { get; set; }
        [DisplayName("Tech")]
        public string CourseTeach { get; set; }

    }
}
