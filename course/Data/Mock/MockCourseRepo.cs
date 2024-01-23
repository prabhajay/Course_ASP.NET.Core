using course.Controllers;
using course.Data.Interface;
using course.Models;

namespace course.Data.Mock
{
    public class MockCourseRepo : ICoursesRepo
    {
        private static List<Course> _courses = new List<Course>
        {
            
        };
        public void Create(Course input)
        {
            int max = _courses.Max(v => v.CourseId);
            input.CourseId = max + 1;
            _courses.Add(input);    
        }

        public void Delete(int id)
        {
            var course = _courses.Find(v => v.CourseId == id);
            if(course != null)
            {
                _courses.Remove(course);
            }
        }

        public void Edit(int id,Course input)
        {
            var course = _courses.Find(v => v.CourseId == id);
            if(course != null)
            {
                course.CourseNumber= input.CourseNumber;
                course.CourseName= input.CourseName;
                course.CourseDescription= input.CourseDescription;
               
            }
        }
        public IEnumerable<Course> GetAll()
        {
            return _courses;
        }
        public Course? GetById(int id)
        {
            return _courses.Find(v=>v.CourseId == id);
        }
    }
}
