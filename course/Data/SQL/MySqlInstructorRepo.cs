using course.Data.Interface;
using course.Models;

namespace course.Data.SQL
{
    public class MySqlInstructorRepo : IInstructorRepo
    {
        private AppDbContext _context;
        public MySqlInstructorRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Instructor input)
        {
            _context.Add(input);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Instructor input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instructor> GetAll()
        {
            return _context.Instructor.ToList();
        }

        public Instructor? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
