using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
   public List<QuestionAndAnswer> QnA;
   public GameObject[] options;
   public int currentQuestion;

   public GameObject Quizpanel;
   public GameObject GoPanel;

   public TextMeshProUGUI QuestionTxt;
   public TextMeshProUGUI ScoreTxt;

   int TotalQuestions = 0;
   public int score;
   int count = 3;

   private void Start()
   {
        TotalQuestions = 3;
        GoPanel.SetActive(false);
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
        ScoreTxt.text = score + "/" + TotalQuestions;
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
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
            options [i].GetComponent <Image>().color = options [i].GetComponent <AnswerScript>().startcolor;
            options[i].GetComponent<AnswerScript>().isCorrect= false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];  

            if(QnA[currentQuestion].CorrectAnswer == i + 1)
            {
               options[i].GetComponent<AnswerScript>().isCorrect= true; 
            }
        }
   }

   void generateQuestion()
   {
        if(count > 0)
        {
            for (int i = 0; i < 3; i++)
            {
                currentQuestion = Random.Range(0, QnA.Count);
                QuestionTxt.text = QnA[currentQuestion].Question;
                SetAnswers();
            }
            count--;
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }

   }
}
