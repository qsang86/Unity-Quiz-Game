using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEndController : MonoBehaviour {

    public Text totalscoreText;
    public Text buttonText;

	// Use this for initialization
	void Start () {

        totalscoreText.text = "Your Score: " + GameManager.INSTANCE.totalScore.ToString();

        StartCoroutine(DataLoading.SendScores());
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.INSTANCE.isScoreSent)
        {
            buttonText.text = "Back to start";
        }
    }

    public void moveToMenu()
    {
        if (GameManager.INSTANCE.isScoreSent)
        {
            Destroy(GameManager.INSTANCE.transform.gameObject);
            SceneManager.LoadScene("Menu");
        }
    }
}
