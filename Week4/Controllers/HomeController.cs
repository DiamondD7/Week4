using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Week4.Models;

namespace Week4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NavigateToPrivacyPage()
        {
            return View(nameof(Privacy));
        }

        [HttpGet("Students"), ProducesResponseType(typeof(StudentModel), 200)]
        public List<StudentModel> GetStudents()
        {
            var students = new List<StudentModel>();
            students.Add(new StudentModel { StudentName = "Student1", UniversityName = "University1" });
            students.Add(new StudentModel { StudentName = "Student2", UniversityName = "University2" });
            return students;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
