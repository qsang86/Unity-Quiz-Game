using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionManager : MonoBehaviour {

    private Question currentQns;
    //private TimerBar timeBar;
    public bool startTimer = false;
    public List<int> indexList = new List<int>();

    private float remainTime = 15f;
    public int randomIndex;
    public int currIndex;

    //private RoundData round;
    //private bool isRoundActive;
    private int endScoreDisplay;
    //private bool timetransit = false;

    //public Text totalscoreText;

    //private int endScore = ScoreValue.scoreValue;

    //[SerializeField]
    //private float timeShift = 1f;

    [SerializeField]
    private Text scoreDisplay;
    
    [SerializeField]
    private Text remainTimeDisplay;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private Text oText;

    [SerializeField]
    private Text xText;

    [SerializeField]
    private Animator ani;

    void Start () {
        scoreDisplay.text = GameManager.INSTANCE.totalScore.ToString();
        //isRoundActive = true;

        currentQns = GameManager.INSTANCE.questions[0];

        questionText.GetComponent<Text>().text = currentQns.QuizQuestion;
        startTimer = true;
        if (currentQns.QuizAnswer == "true")
        {
            oText.text = "WRONG";
            xText.text = "CORRECT";

        }
        else if (currentQns.QuizAnswer == "false")
        {
            oText.text = "CORRECT";
            xText.text = "WRONG";
        }
        startTimer = true;
    }   

    void Update()
    {
       
    }

    void UpdateTimeRemainDisplay()
    {
        remainTimeDisplay.text = Mathf.Round(remainTime).ToString();
    }


    //get the questions from the list of questions with the random index
    /*void SetQuestions()
    {
        int randomIndex = Random.Range(0, questions.Count());
        currentQns = questions[randomIndex];
        questionText.GetComponent<Text>().text = currentQns.QuizQuestion;

        if (currentQns.QuizAnswer == "false")
        {
            oText.text = "WRONG";
            xText.text = "CORRECT";
            
        }
        else if(currentQns.QuizAnswer == "true")
        {
            oText.text = "CORRECT";
            xText.text = "WRONG";
        }
        
    }*/

    /*void CheckTimeLeft()
    {
        if(timeBar.timeLeft == 0)
        {
            timetransit = true;
            TransitNext();
            timetransit = false;
        }
    }*/

    void TransitNext()
    {
        GameManager.INSTANCE.questions.Remove(this.currentQns);

        if (GameManager.INSTANCE.questions.Count == 0)
        {
            SceneManager.LoadScene("GameEnd");
            return;
        }

       
        //load the next question's scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartCoroutine(LoadAfterDelay(0.5f));
    }

    IEnumerator LoadAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    //it shows what happens if the buttons are clicked
    public void ChooseO()
    {
        ani.SetTrigger("True");
        //ani.SetBool("Selected", true);
        if (currentQns.QuizAnswer == "true")
        {
            Debug.Log("yes");

            //add 10 point
            
            GameManager.INSTANCE.totalScore += 10;
            scoreDisplay.text = GameManager.INSTANCE.totalScore.ToString();

        }
        else
        {
            Debug.Log("No");
        }

        TransitNext();
    }
    
    public void ChooseX()
    {
        ani.SetTrigger("False");
        //ani.SetBool("Selected", true);
        if (currentQns.QuizAnswer == "false")
        {
            Debug.Log("yes");

            GameManager.INSTANCE.totalScore += 10;
            scoreDisplay.text = GameManager.INSTANCE.totalScore.ToString();

        }
        else
        {
            Debug.Log("No");
        }

        TransitNext();
    }
   
}
