using Microsoft.AspNetCore.Mvc;
using StudentCourseRegistration.Models;

namespace StudentCourseRegistration.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "Aarav Patel", Email = "aarav.patel@marwadiuniversity.ac.in", Course = "Computer Engineering", Semester = 5 },
            new Student { Id = 2, Name = "Diya Shah", Email = "diya.shah@marwadiuniversity.ac.in", Course = "Information Technology", Semester = 5 }
        };

        // GET: /Student/Index
        public IActionResult Index()
        {
            return View(_students);
        }

        // GET: /Student/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = _students.Count > 0 ? _students.Max(s => s.Id) + 1 : 1;
                _students.Add(student);
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }

        // GET: /Student/Details/1
        public IActionResult Details(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}