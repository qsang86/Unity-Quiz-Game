using CotyWebApp.App_Code.DataSet1TableAdapters;
using CotyWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CotyWebApp.App_Code.DataSet1;

namespace CotyWebApp.DAL
{
    public class ScoresDAL
    {
        public static ScoresDataTable getAll()
        {
            ScoresDataTable results = new ScoresDataTable();

            ScoresTableAdapter adapter = new ScoresTableAdapter();
            adapter.Fill(results);

            return results;
        }

        public static ScoresDataTable getScoresByUser(int userID)
        {
            ScoresDataTable results = new ScoresDataTable();

            ScoresTableAdapter adapter = new ScoresTableAdapter();
            adapter.FillBy(results, userID);

            return results;
        }

        public static MaxScoresDataTable getHighestScoresByUser(int userID)
        {

            MaxScoresDataTable results = new MaxScoresDataTable();

            MaxScoresTableAdapter adapter = new MaxScoresTableAdapter();
            adapter.FillMaxScoreBy(results, userID);

            return results;
        }

        public static Boolean saveScore(Score score)
        {
            ScoresTableAdapter adapter = new ScoresTableAdapter();
            return adapter.Insert(score.Day, score.UserScore, score.UserID) > 0;
        }

        public static Boolean deleteScore(int scoreID)
        {
            ScoresTableAdapter adapter = new ScoresTableAdapter();
            return adapter.Delete(scoreID) > 0;
        }
    }
}