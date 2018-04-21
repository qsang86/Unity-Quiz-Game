using CotyWebApp.DAL;
using CotyWebApp.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using static CotyWebApp.App_Code.DataSet1;

namespace CotyWebApp.Controller
{
    public class ScoresController : ApiController
    {

        [HttpGet]
        [ActionName("Get")]
        public JsonResult<List<Score>> GetScoresByUser(int userid)
        {
            List<Score> results = new List<Score>();

            ScoresDataTable dt = ScoresDAL.getScoresByUser(userid);
            foreach (ScoresRow row in dt.Rows)
            {
                Score score = new Score();

                score.ID = Convert.ToInt32(row[0]);
                score.Day = Convert.ToString(row[1]);
                score.UserScore = Convert.ToInt32(row[2]);
                score.Timestamp = Convert.ToDateTime(row[3]);
                score.UserID = Convert.ToInt32(row[4]);
                
                results.Add(score);
            }

            return Json<List<Score>>(results);
        }

        [HttpGet]
        [ActionName("GetMax")]
        public JsonResult<List<Score>> GetMaxScoresByUser(int userid)
        {
            List<Score> results = new List<Score>();

            MaxScoresDataTable dt = ScoresDAL.getHighestScoresByUser(userid);
            foreach (MaxScoresRow row in dt.Rows)
            {
                Score score = new Score();
                
                score.Day = Convert.ToString(row[0]);
                score.UserScore = Convert.ToInt32(row[1]);

                results.Add(score);
            }

            return Json<List<Score>>(results);
        }

        public void Post([FromBody] dynamic data)
        {

            Score score = new Score();
            score.Day = data.day;
            score.UserScore = data._score;
            score.UserID = data.userID;

            ScoresDAL.saveScore(score);
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