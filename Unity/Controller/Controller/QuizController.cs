using CotyWebApp.DAL;
using CotyWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Http.Cors;
using static CotyWebApp.App_Code.DataSet1;

namespace CotyWebApp.Controller
{
    [EnableCors(origins: "http://localhost:50237", headers: "*", methods: "*")]
    public class QuizController : ApiController
    {
        // GET api/quiz/5
     
        public JsonResult<List<Quiz>> Get(string day)
        {
            List<Quiz> results = new List<Quiz>();

            QuizDataTable dt = QuizDAL.getAllbyDay(day);
            foreach (QuizRow row in dt.Rows)
            {
                Quiz quiz = new Quiz();

                quiz.QuizId = Convert.ToInt32(row[0]);
                quiz.QuizQuestion = Convert.ToString(row[1]);
                quiz.QuizPossibleAnswer1 = Convert.ToString(row[2]);
                quiz.QuizPossibleAnswer2 = Convert.ToString(row[3]);
                quiz.QuizPossibleAnswer3 = Convert.ToString(row[4]);
                quiz.QuizPossibleAnswer4 = Convert.ToString(row[5]);
                quiz.QuizAnswer = Convert.ToString(row[6]);

                results.Add(quiz);
            }

            return Json<List<Quiz>>(results);
        }

        [ActionName("GetQuizByDivison")]
        [Route("api/quiz/4/{division}")]
        public JsonResult<List<Quiz>> GetQuizByDivision(string division)
        {
            List<Quiz> results = new List<Quiz>();

            QuizDataTable dt = QuizDAL.getQuizFromDivision(division);
            foreach (QuizRow row in dt.Rows)
            {
                Quiz quiz = new Quiz();

                //SELECT quizId, quizQuestion, quizPossibleAnswer1, quizPossibleAnswer2, quizPossibleAnswer3, quizPossibleAnswer4, quizAnswer, quizDay, quizDivision
                //FROM Quiz
                //WHERE(quizDay = '4') AND(quizDivision = @division);
                quiz.QuizId = Convert.ToInt32(row[0]);
                quiz.QuizQuestion = Convert.ToString(row[1]);
                quiz.QuizPossibleAnswer1 = Convert.ToString(row[2]);
                quiz.QuizPossibleAnswer2 = Convert.ToString(row[3]);
                quiz.QuizPossibleAnswer3 = Convert.ToString(row[4]);
                quiz.QuizPossibleAnswer4 = Convert.ToString(row[5]);
                quiz.QuizAnswer = Convert.ToString(row[6]);
                quiz.QuizDay = Convert.ToString(row[7]);
                quiz.QuizDivision = Convert.ToString(row[8]);

                results.Add(quiz);
            }

            return Json<List<Quiz>>(results);
        }


        [ActionName("GetQuizRandDivision")]
        [Route("api/quiz/4/{division}/rand")]
        public JsonResult<List<Quiz>> GetQuizRandDivision(string division)
        {
            List<Quiz> results = new List<Quiz>();

            QuizDataTable dt = QuizDAL.getQuizRandFromDivision(division);
            foreach (QuizRow row in dt.Rows)
            {
                Quiz quiz = new Quiz();

                //SELECT quizId, quizQuestion, quizPossibleAnswer1, quizPossibleAnswer2, quizPossibleAnswer3, quizPossibleAnswer4, quizAnswer, quizDay, quizDivision
                //FROM Quiz
                //WHERE(quizDay = '4') AND(quizDivision = @division);
                quiz.QuizId = Convert.ToInt32(row[0]);
                quiz.QuizQuestion = Convert.ToString(row[1]);
                quiz.QuizPossibleAnswer1 = Convert.ToString(row[2]);
                quiz.QuizPossibleAnswer2 = Convert.ToString(row[3]);
                quiz.QuizPossibleAnswer3 = Convert.ToString(row[4]);
                quiz.QuizPossibleAnswer4 = Convert.ToString(row[5]);
                quiz.QuizAnswer = Convert.ToString(row[6]);
                quiz.QuizDay = Convert.ToString(row[7]);
                quiz.QuizDivision = Convert.ToString(row[8]);

                results.Add(quiz);
            }

            return Json<List<Quiz>>(results);
        }


        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}