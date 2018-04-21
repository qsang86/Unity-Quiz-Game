using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CotyWebApp.Entity
{
    public class Quiz
    {
        int quizId;
        string quizQuestion;
        string quizPossibleAnswer1;
        string quizPossibleAnswer2;
        string quizPossibleAnswer3;
        string quizPossibleAnswer4;
        string quizAnswer;
        string quizDay;
        string quizDivision;


        public int QuizId { get => quizId; set => quizId = value; }
        public string QuizQuestion { get => quizQuestion; set => quizQuestion = value; }
        public string QuizPossibleAnswer1 { get => quizPossibleAnswer1; set => quizPossibleAnswer1 = value; }
        public string QuizPossibleAnswer2 { get => quizPossibleAnswer2; set => quizPossibleAnswer2 = value; }
        public string QuizPossibleAnswer3 { get => quizPossibleAnswer3; set => quizPossibleAnswer3 = value; }
        public string QuizPossibleAnswer4 { get => quizPossibleAnswer4; set => quizPossibleAnswer4 = value; }
        public string QuizAnswer { get => quizAnswer; set => quizAnswer = value; }
        public string QuizDay { get => quizDay; set => quizDay = value; }
        public string QuizDivision { get => quizDivision; set => quizDivision = value; }


    }
}