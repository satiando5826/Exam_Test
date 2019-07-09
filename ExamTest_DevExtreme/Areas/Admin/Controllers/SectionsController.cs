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
    public class SectionsController : Controller
    {
        private readonly ExamTestDbContext _db;

        public SectionsController(ExamTestDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object GetSections(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Sections, loadOptions);
        }

        

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newSection = new Section();
            newSection.sectionId = new Guid();
            newSection.sectionId = Guid.NewGuid();

            JsonConvert.PopulateObject(values, newSection);

            if (!TryValidateModel(newSection))
                return BadRequest();

            _db.Sections.Add(newSection);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var section = _db.Sections.First(s => s.sectionId == key);
            JsonConvert.PopulateObject(values, section);

            if (!TryValidateModel(section))
                return BadRequest();

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var section = _db.Sections.First(a => a.sectionId == key);
            _db.Sections.Remove(section);
            _db.SaveChanges();
        }

    }
}