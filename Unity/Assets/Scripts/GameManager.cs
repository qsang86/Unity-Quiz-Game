using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern int GetUserID();

    public static GameManager INSTANCE;

    public bool isQuestionsLoaded = false;
    public bool isScoreSent = false;
    public List<Question> questions = null;
    public int totalScore;
    public int userid;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        INSTANCE = this;
    }

    // Use this for initialization
    void Start () {

        //try
        //{
            userid = GetUserID();
        //} catch (Exception e)
        //{
        //    userid = 30;
        //}

        Debug.Log("Current User: " + userid);

        StartCoroutine(DataLoading.LoadQuestions());
	}
}
