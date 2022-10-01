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
   
   public GameObject Canva_main;
   public GameObject Canva_Quiz;
   public GameObject Canva_Article;

   public TextMeshProUGUI QuestionTxt;
   public TextMeshProUGUI ScoreTxt;
   public TextMeshProUGUI AnsTxt;

   public int score;
   
   private int currentQuestion;
   private int count = 0;
   
   public void OnEnable()
   {
        Debug.Log("Quiz start!");
        score = 0;
        count = 0;
        GoPanel.SetActive(false);
        Quizpanel.SetActive(true);
        JsonReader.section = JsonReader.information.game[MainSystem.category];
        generateQuestion();
   }

   public void retry()
   {
        Canva_Quiz.SetActive(false);
        Canva_main.SetActive(true);
   }

    public TextMeshProUGUI text_category;
    public GameObject text_pass;
    public GameObject text_failed;
    public void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        text_category.text = JsonReader.information.game[MainSystem.category].topic;
        ScoreTxt.text = score + "/ 3";
        if (score == 3)
        {
            // MainSystem.status[MainSystem.category,1] = 2;
            MainSystem.collected[MainSystem.category] += 1;
            MainSystem.mission = 2;
            text_failed.SetActive(false);
            text_pass.SetActive(true);
        }
        else
        {
            text_pass.SetActive(false);
            text_failed.SetActive(true);
        }
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
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = JsonReader.section.quiz[currentQuestion].answers[i];  

            if(JsonReader.section.quiz[currentQuestion].correct == i + 1)
            {
               options[i].GetComponent<AnswerScript>().isCorrect= true; 
            }
        }
   }

   void generateQuestion()
   {
        if(count < 3)
        {
            currentQuestion = Random.Range(0, JsonReader.section.quiz.Length);
            while (JsonReader.section.quiz[currentQuestion].is_selected)
                currentQuestion = Random.Range(0, JsonReader.section.quiz.Length);
            JsonReader.section.quiz[currentQuestion].is_selected = true;
            QuestionTxt.text = JsonReader.section.quiz[currentQuestion].question;
            AnsTxt.text = JsonReader.section.quiz[currentQuestion].correct.ToString();
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
