using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Canva_main;
   public GameObject Canva_Quiz;
    
   public void return_Home()
   {
        Debug.Log("end");
        Canva_Quiz.SetActive(false);
        Canva_main.SetActive(true);
   }
}
