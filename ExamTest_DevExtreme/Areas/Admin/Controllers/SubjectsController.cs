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
        [HttpGet]
        public object GetSubject(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Subjects, loadOptions);
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newSubject = new Subject();
            newSubject.subjectsId = new Guid();
            newSubject.subjectsId = Guid.NewGuid();

            Guid testGuid = Guid.NewGuid();

            JsonConvert.PopulateObject(values, newSubject);

            if (!TryValidateModel(newSubject))
                return BadRequest();

            _db.Subjects.Add(newSubject);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var subject = _db.Subjects.First(a => a.subjectsId == key);
            JsonConvert.PopulateObject(values, subject);

            if (!TryValidateModel(subject))
                return BadRequest();

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var subject = _db.Subjects.First(a => a.subjectsId == key);
            _db.Subjects.Remove(subject);
            _db.SaveChanges();
        }

        
    }
}