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
    public class QuestionsController : Controller
    {
        private readonly ExamTestDbContext _db;

        public QuestionsController(ExamTestDbContext db)
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
            List<Question> questions = _db.Questions.Include(q => q.Section).ToList();
            return View(questions);
        }

        [HttpGet]
        public object GetQuestions(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Questions.Include(q=>q.Section), loadOptions);
        }

        [HttpGet]
        public object GetExams(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Exams, loadOptions);
        }

        [HttpGet]
        public object GetSections(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Sections, loadOptions);
        }

        [HttpGet]
        public object GetQuestionExams(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.QuestionExams, loadOptions);
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newquestion = new Question();
            newquestion.questionId = new Guid();
            newquestion.questionId = Guid.NewGuid();
            JsonConvert.PopulateObject(values, newquestion);

            if (!TryValidateModel(newquestion))
                return BadRequest();

            _db.Questions.Add(newquestion);
            
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var question = _db.Questions.First(a => a.questionId == key);
            JsonConvert.PopulateObject(values, question);

            if (!TryValidateModel(question))
                return BadRequest();

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var question = _db.Questions.First(a => a.questionId == key);
            _db.Questions.Remove(question);
            _db.SaveChanges();
        }


    }
}