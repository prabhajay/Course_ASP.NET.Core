using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace course.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int StudentId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Email")]
        public string Email {  get; set; }
        [DisplayName("Phone")]
        public string Phone { get; set; }
       // [DisplayName("Course Id")]
       // [ForeignKey("Course")]
       // public int? courseId {  get; set; }

        //public Course course { get; set; }
    }
}
