using AT1__PerfectPolicy_.DTO;
using AT1__PerfectPolicy_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT1__PerfectPolicy_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        // Constructor injection to provide access to database
        private readonly QuizContext _context;
        public ReportController(QuizContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gathers all questions connected to a quiz
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        [HttpGet("QuizQuestionCountReport")]
        public IActionResult QuizQuestionCountReport(DateTime? from, DateTime? to)
        {

            var quizzes = _context.Quizs.Include(c => c.Questions);

            //if(from != null)
            //{
            //    teachers.Where(c => c.Hired > from);
            //}
            //if (to != null)
            //{
            //    teachers.Where(c => c.Hired < to);
            //}

            var quizquestioncountlist = quizzes.Select(c => new QuizQuestionCount
            {
                QuizTitle = c.Title,
                QuestionCount = c.Questions.Count
            }).ToList();

            return Ok(quizquestioncountlist);
        }

    }
}
