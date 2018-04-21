using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Question {

    //public string questionSet;
    //public bool isAnswer;
    public int QuizId;
    public string QuizQuestion;
    public string QuizAnswer;
    public string QuizDay;

    public Question()
    {
        QuizId = 0;
        QuizQuestion = null;
        QuizAnswer = null;
        QuizDay = null;

    }

   public string printContent()
    {
        return QuizQuestion + QuizAnswer.ToString() + QuizDay;
    }
}
