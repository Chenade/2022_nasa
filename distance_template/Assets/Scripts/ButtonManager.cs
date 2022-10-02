using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject Cepheid;
    public GameObject Supernova;
    
    // Start is called before the first frame update
    void Start()
    {
       Supernova.SetActive(false); 
    }

    public void chooseButton()
    {
         if(Cepheid)
         {
            Supernova.SetActive(false);
            Cepheid.SetActive(true);
         }
         if(Supernova)
         {
            Supernova.SetActive(true);
            Cepheid.SetActive(false);
         }
    }
}
