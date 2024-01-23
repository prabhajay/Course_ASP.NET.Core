using course.Data.Interface;
using course.Models;
using System.Net.Mail;

namespace course.Data.Mock
{
    public class MockInstructorRepo :IInstructorRepo
    {
        private static List<Instructor> _instructors = new List<Instructor>
        {
             
        };
        public void Create(Instructor input)
        {
            int max = _instructors.Max(v => v.InstructorId);
            input.InstructorId = max + 1;
            _instructors.Add(input);
        }
        public void Delete(int id)
        {
            var instructor =_instructors.Find(v=>v.InstructorId == id);
            if(instructor != null)
            {
                _instructors.Remove(instructor);
            }
        }
        public IEnumerable<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor? GetById(int id)
        {
            return _instructors.Find(v => v.InstructorId == id);
        }
        public void Edit(int id, Instructor input)
        {
            var instructor=_instructors.Find(v=>v.InstructorId == id);
            if(instructor != null)
            {
                instructor.FirstName = input.FirstName;
                instructor.LastName = input.LastName;
                instructor.EmailAddress = input.EmailAddress;
                instructor.CourseTeach = input.CourseTeach;
            }
        }
    }
}
