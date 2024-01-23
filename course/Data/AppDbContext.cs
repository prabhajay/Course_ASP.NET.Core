using course.Controllers;
using course.Models;
using Microsoft.EntityFrameworkCore;

namespace course.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 211, CourseNumber = "ACCT", CourseName = "Accounting I", CourseDescription = "Accounting Courses detials" },
                new Course { CourseId = 212, CourseNumber = "ACCT", CourseName = "Accounting II", CourseDescription = "Accounting Courses details" },
                new Course { CourseId = 220, CourseNumber = "CIS", CourseName = "Database Design and Implementation", CourseDescription = "Database and implemetation course details" },
                new Course { CourseId = 261, CourseNumber = "CIS ", CourseName = "Intro to Statistics", CourseDescription = "Intro to Statistics details" },
                new Course { CourseId = 362, CourseNumber = "CIS", CourseName = "Statistical Applications", CourseDescription = "Statistical Applications" }
            );
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { InstructorId = 103, FirstName = "John", LastName = "Job", EmailAddress = "John@gmail.com", CourseTeach = "CIS" },
                new Instructor { InstructorId = 104, FirstName = "willam", LastName = "John", EmailAddress = "Willam@gmail.com", CourseTeach = "ACCT" },
                new Instructor { InstructorId = 105, FirstName = "xxx", LastName = "yyy", EmailAddress = "xxxYYY@gmail.com", CourseTeach = "CIS" },
                new Instructor { InstructorId = 106, FirstName = "abc", LastName = "def", EmailAddress = "abcdef@gmail.com", CourseTeach = "ACCT" },
                new Instructor { InstructorId = 107, FirstName = "pqr", LastName = "stu", EmailAddress = "pqrstr@gmail.com", CourseTeach = "CIS" }
                );

            modelBuilder.Entity<Student>().HasData(
             new Student { StudentId = 400, FirstName = "Johu", LastName = "Job", Email = "Johu@gmail.com", Phone = "403-222-3222" },
             new Student { StudentId = 401, FirstName = "Brewer", LastName = "Juliette", Email = "brewer@gmail.com", Phone = "403-354-2321" },
             new Student { StudentId = 402, FirstName = "John", LastName = "Smith", Email = "john@gmail.com", Phone = "403-342-3432" },
             new Student { StudentId = 403, FirstName = "Robertson", LastName = "Gerald", Email = "robertson@gmail.com", Phone = "403-322-2322" },
             new Student { StudentId = 404, FirstName = "Robertson", LastName = "Gerald", Email = "robertson@gmail.com", Phone = "403-322-2322" }
                );
        }
    }
}
