using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using System.Linq;
using System;

public class DataLoading : MonoBehaviour
{
    private static string base_url = "https://cotyonboarding.azurewebsites.net";
    public static string extension = "/api/";

    public static IEnumerator LoadQuestions()
    {
        var www = new WWW(base_url + extension + "quiz/" + "2/");
        yield return www;

        // check for errors
        if (www.error == null || www.error.Length == 0)
        {
            String currData = "{ \"questions\": " + www.text + " }"; // Append questions to get an object instead of a list

            if (www.text.Length < 2)
                yield break;

            Debug.Log(currData);
            //QuestionCollection col =  JsonUtility.FromJson<QuestionCollection>(currData);

            System.Random rand = new System.Random();
            GameManager.INSTANCE.questions = JsonUtility.FromJson<QuestionCollection>(currData).questions.OrderBy(c => rand.Next()).Select(c => c).ToList();
            GameManager.INSTANCE.isQuestionsLoaded = true;
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }

    public static IEnumerator SendScores() // pass in the url of server
    {
        //Dictionary<string, string> postHeader = new Dictionary<string, string>();
        var postHeader = new Dictionary<string, string>();
        postHeader.Add("Content-Type", "application/json");
        byte[] biteArr = System.Text.Encoding.UTF8.GetBytes("{\"day\":" + 2 + "," + "\"_score\":" + GameManager.INSTANCE.totalScore + "," + "\"userID\":" + GameManager.INSTANCE.userid + "}");
        WWW w = new WWW("https://cotyonboarding.azurewebsites.net/api/scores", biteArr, postHeader);

        yield return w;
        if (w.error == null || w.error.Length == 0)
        {
            GameManager.INSTANCE.isScoreSent = true;
        }
        else
        {
            Debug.Log("WWW Error: " + w.error);
        }
    }


}
