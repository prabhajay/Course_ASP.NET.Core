using course.Data.Interface;
using course.Models;

namespace course.Data.SQL
{
    public class MySqlCourseRepo : ICoursesRepo
    {
        private readonly AppDbContext _context;
        public MySqlCourseRepo(AppDbContext context)
        {
            _context= context;
        }
        public void Create(Course input)
        {
            _context.Add(input);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Course input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Course.ToList();
        }

        public Course? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
