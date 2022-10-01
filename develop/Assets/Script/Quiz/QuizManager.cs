using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
   public GameObject[] options;

   public GameObject Quizpanel;
   public GameObject GoPanel;

   public TextMeshProUGUI QuestionTxt;
   public TextMeshProUGUI ScoreTxt;
   public TextMeshProUGUI AnsTxt;

   public int score;
   
   private int currentQuestion;
   private int count = 0;
   private int[] selected;
   
   private void Start()
   {
        GoPanel.SetActive(false);
        JsonReader.section = JsonReader.information.game[MainSystem.category - 1];
        generateQuestion();
   }

   public void retry()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

    public void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/ 3";
    }

    public void correct()
    {
        score += 1;
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        generateQuestion();
    }

   void SetAnswers()
   {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent <Image>().color = options [i].GetComponent <AnswerScript>().startcolor;
            options[i].GetComponent<AnswerScript>().isCorrect= false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = JsonReader.section.members[currentQuestion].answers[i];  

            if(JsonReader.section.members[currentQuestion].correct == i + 1)
            {
               options[i].GetComponent<AnswerScript>().isCorrect= true; 
            }
        }
   }

   void generateQuestion()
   {
        if(count < 3)
        {
            currentQuestion = Random.Range(0, JsonReader.section.members.Length);
            while (JsonReader.section.members[currentQuestion].is_selected)
                currentQuestion = Random.Range(0, JsonReader.section.members.Length);
            JsonReader.section.members[currentQuestion].is_selected = true;
            QuestionTxt.text = JsonReader.section.members[currentQuestion].question;
            AnsTxt.text = JsonReader.section.members[currentQuestion].correct.ToString();
            SetAnswers();
            count += 1;
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }

   }
}
