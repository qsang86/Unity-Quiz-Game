using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class QuestionLoader : MonoBehaviour {

    [SerializeField]
    private string questionPath;

    private QuestionCollection questionCollections;

    [ContextMenu("Load Questions: ")]
    private void LoadQuestions()
    {
        using (StreamReader stream = new StreamReader(questionPath))
        {
            string datajson = stream.ReadToEnd();
            questionCollections = JsonUtility.FromJson<QuestionCollection>(datajson);
        }
        Debug.Log("question loaded? >>" + questionCollections.questions.Count);    
        FindObjectOfType<Text>().text= questionCollections.ToString();
    }
}
