


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace course.Models
{
    public class Course
    {
        [Key]
        [DisplayName("Course Id")]
        public int CourseId { get; set; }
        [DisplayName("Course Number")]
        public string CourseNumber {  get; set; }

        [DisplayName("Course Name")]
        public string CourseName { get; set; }
        [DisplayName("Description")]
        public string CourseDescription { get; set; }

    }
}
