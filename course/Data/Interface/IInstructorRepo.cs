using course.Models;

namespace course.Data.Interface
{
    public interface IInstructorRepo
    {
        IEnumerable<Instructor> GetAll();
        void Create(Instructor input);
        Instructor? GetById(int id);
        void Edit(int id, Instructor input);
        void Delete(int id);


    }
}
