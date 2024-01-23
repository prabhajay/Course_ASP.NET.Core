using course.Data.Interface;
using course.Models;
using System.Runtime.CompilerServices;

namespace course.Data.Mock
{
    public class MockStudentRepo:IStudentRepo
    {
        private static List<Student> _students = new List<Student>
        {
            
        };

        public void Create(Student input)
        {
            int max = _students.Max(v => v.StudentId);
            input.StudentId = max + 1;
            _students.Add(input);
        }

        public void Delete(int id)
        {
            var student = _students.Find(v=> v.StudentId == id);
            if(student !=null)
            {
                _students.Remove(student);
            }
        }
        public void Edit(int id, Student input)
        {
            var student = _students.Find(v => v.StudentId == id);
            if(student != null)
            {
                student.FirstName = input.FirstName;
                student.LastName = input.LastName;
                student.Email = input.Email;
                student.Phone = input.Phone;
            }
        }

        public IEnumerable<Student> GetAll()

        {
            return _students;
        }

        public Student? GetById(int id)
        {
            return _students.Find(v => v.StudentId == id);

        }
    }
}
