using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class QuestionCollection {
       
    
    public QuestionCollection()
    {
        questions = new List<Question>(); 
    }
  
    public List<Question> questions;
    
    public void PrintQuestions()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            Debug.Log(questions[i].printContent());
        }
    }
    //public QuestionCollection[] questions;
    //public string questionSet;
    //public bool isAnswer;
    
}

