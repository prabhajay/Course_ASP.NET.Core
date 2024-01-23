using course.Data.Interface;
using course.Data.Mock;
using course.Data.SQL;
using course.Models;
using Microsoft.AspNetCore.Mvc;

namespace course.Controllers
{
    public class CourseController : Controller
    {

        //private readonly ICoursesRepo _courseRepo = new MockCourseRepo();
        //
       // private readonly ICoursesRepo _courseRepo = new MySqlCourseRepo();
        private readonly IStudentRepo _studentRepo = new MockStudentRepo();
        private readonly ICoursesRepo _coursesRepo;
        public CourseController(ICoursesRepo coursesRepo)
        {
            _coursesRepo = coursesRepo;
        }
        public IActionResult Index()
        {
            var courses = _coursesRepo.GetAll();
            return View(courses);
           
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course input)
        {
            _coursesRepo.Create(input);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var course = _coursesRepo.GetById(id);
            return View(course);

        }

        [HttpPost]
        public IActionResult Edit(Course input)
        {
            _coursesRepo.Edit(input.CourseId, input);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var course = _coursesRepo.GetById(id);
            return View(course);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _coursesRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            var course= _coursesRepo.GetById(id);
            if(course == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }
        
    }
}
