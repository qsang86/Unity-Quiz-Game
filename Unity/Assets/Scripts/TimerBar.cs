using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour {

    //public bool timeLeft;
    Image timeBar;
    public float timeSet = 20f;
    public float timeLeft;
    public GameObject timesUpText;
    public bool nonwait = false;
    public QuestionManager gm;

    void Start()
    {
        timeBar = GetComponent<Image>();
        timeLeft = timeSet;

    }

    void Update()
    {
        if (gm.startTimer)
        {
            UpdateTime();
        }
    }

    public void UpdateTime()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / timeSet;
            //Debug.Log(timeLeft);
        }
        else
        {
            Time.timeScale = 0;
            //Debug.Log("debug:" + timeLeft);
        }
    }
}
