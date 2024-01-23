using course.Models;

namespace course.Data.Interface
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAll();
        void Create(Student input);
        Student? GetById(int id);
        void Edit(int id, Student input);
        void Delete(int id);
    }
}
