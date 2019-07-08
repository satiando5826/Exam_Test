using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Test.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ExamTest_DevExtreme.Areas.Admin
{
    [Area("Admin")]
    public class SubjectsController : Controller
    {
        private readonly ExamTestDbContext _db;

        public SubjectsController(ExamTestDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}