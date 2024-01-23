using course.Data.Interface;
using course.Data.Mock;
using course.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace course.Controllers
{
    public class StudentController : Controller
    {
        //private readonly IStudentRepo _studentRepo = new MockStudentRepo();
        private readonly ICoursesRepo _courseRepo = new MockCourseRepo();
        private readonly IStudentRepo _studentRepo;
        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public IActionResult Index()
        {
            var students = _studentRepo.GetAll();
            return View(students);
   
        }
        public IActionResult Details(int id)
        {
            var student= _studentRepo.GetById(id);
            if(student == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        public IActionResult Edit(int id)
        {
            var course = _studentRepo.GetById(id);
            return View(course);

        }
        [HttpPost]
        public IActionResult Edit(Student input)
        {
            _studentRepo.Edit(input.StudentId, input);
            return RedirectToAction(nameof(Index));
        }
       public IActionResult Delete(int id)
        {
                var student=_studentRepo.GetById(id);
                return View(student);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            var studentList = _studentRepo.GetAll();
            ViewBag.Students = new SelectList(studentList, "StudentId");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student input)
        {
            _studentRepo.Create(input);
            return RedirectToAction(nameof(Index));
        }
        public IEnumerable<string> GetCoursesByStudentEnroll(int? id)
        {
            var res = _studentRepo.GetAll()
                 .Where(p => p.StudentId== id)
                 .Select(p => p.StudentId + "\t$" + p.FirstName + "<br>");
            if (res == null || res.Count() == 0)
            {
                return new List<string> { "No student Enroll this course" };
            }
            return res;
        }
    }
}
