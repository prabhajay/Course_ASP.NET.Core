using course.Data.Interface;
using course.Data.Mock;
using course.Models;
using Microsoft.AspNetCore.Mvc;

namespace course.Controllers
{
    public class InstructorController : Controller
    {
        //private readonly IInstructorRepo _insturctorRepo = new MockInstructorRepo();
        private readonly IInstructorRepo _instructorRepo;

        public InstructorController(IInstructorRepo insturctorRepo)
        {
            _instructorRepo = insturctorRepo;
        }

        public IActionResult Index()
        {
            var instructors = _instructorRepo.GetAll();

            return View(instructors);
        }
        public IActionResult Edit(int id)
        {
            var instructor = _instructorRepo.GetById(id);
            return View(instructor);

        }


        public IActionResult Details(int id)
        {
            var instructor = _instructorRepo.GetById(id);
            if(instructor == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(instructor);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Instructor input)
        {
            _instructorRepo.Create(input);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Edit(Instructor input)
        {
            _instructorRepo.Edit(input.InstructorId, input);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var instructor = _instructorRepo.GetById(id);
            return View(instructor);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _instructorRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
