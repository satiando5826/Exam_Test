using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Exam_Test.DAL;
using Exam_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace ExamTest_DevExtreme.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExamsController : Controller
    {
        private readonly ExamTestDbContext _db;

        public ExamsController(ExamTestDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public object GetExams(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Exams, loadOptions);
        }
        
        [HttpGet]
        public object GetSubjects(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Subjects, loadOptions);
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newExam = new Exam();
            newExam.examId = new Guid();
            newExam.examId = Guid.NewGuid();
            JsonConvert.PopulateObject(values, newExam);

            if (!TryValidateModel(newExam))
                return BadRequest();

            _db.Exams.Add(newExam);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var exam = _db.Exams.First(a => a.examId == key);
            JsonConvert.PopulateObject(values, exam);

            if (!TryValidateModel(exam))
                return BadRequest();

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var exam = _db.Exams.First(a => a.examId == key);
            _db.Exams.Remove(exam);
            _db.SaveChanges();
        }


    }
}