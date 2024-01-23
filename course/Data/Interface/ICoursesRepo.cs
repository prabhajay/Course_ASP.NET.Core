using course.Models;

namespace course.Data.Interface
{
    public interface ICoursesRepo
    {
        IEnumerable<Course> GetAll();
        void Create(Course input);
        Course? GetById(int id);

        void Edit(int id, Course input);

        void Delete(int id);
    }
}
