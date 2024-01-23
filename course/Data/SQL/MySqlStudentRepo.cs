using course.Data.Interface;
using course.Models;

namespace course.Data.SQL
{
    public class MySqlStudentRepo : IStudentRepo
    {
        private readonly AppDbContext _context;
        public MySqlStudentRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Student input)
        {
            _context.Add(input);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Student input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Student.ToList();
        }

        public Student? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
