using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    [SerializeField]
    private Text start_button;

    //private float waitTime = 2f;

    private void Update()
    {
        if (GameManager.INSTANCE.isQuestionsLoaded)
        {
            start_button.text = "Start";
        }
    }

    public void moveToGame()
    {
        if (GameManager.INSTANCE.isQuestionsLoaded)
        {
            SceneManager.LoadScene("StarterScene");
        }
    }
}

