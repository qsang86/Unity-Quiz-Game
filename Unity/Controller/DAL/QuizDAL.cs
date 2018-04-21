using CotyWebApp.App_Code.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static CotyWebApp.App_Code.DataSet1;

namespace CotyWebApp.DAL
{
    public class QuizDAL
    {

        public static QuizDataTable getAll()
        {
            QuizDataTable results = new QuizDataTable();

            QuizTableAdapter adapter = new QuizTableAdapter();
            adapter.Fill(results);

            return results;
        }

        public static QuizDataTable getAllbyDay(string day)
        {
            QuizDataTable results = new QuizDataTable();

            QuizTableAdapter adapter = new QuizTableAdapter();

            adapter.FillBy(results,day);

            return results;
        }


        public static QuizDataTable getQuizFromDivision(string division)
        {
            QuizDataTable results = new QuizDataTable();

            QuizTableAdapter adapter = new QuizTableAdapter();

            adapter.FillBy1(results, division);

            return results;
        }

        public static QuizDataTable getQuizRandFromDivision(string division)
        {
            QuizDataTable results = new QuizDataTable();

            QuizTableAdapter adapter = new QuizTableAdapter();

            adapter.FillBy2(results, division);

            return results;
        }



    }

}