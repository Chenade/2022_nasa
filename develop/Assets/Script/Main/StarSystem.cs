using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSystem : MonoBehaviour
{

    [System.Serializable]
    public class Star
    {
        public int btn_id;
        public int status;
        public int category;
        public GameObject target_canvas;
        public GameObject target_star;
    }

    public GameObject   Canvas_Main;
    public GameObject   Canvas_Minigame;
    public GameObject   Canvas_Article;
    public GameObject   Canvas_Quiz;
    public GameObject[] Canva_Simulator;
    public GameObject   Canvas_Distance;

    public GameObject   cv_1;

    public static Star[] information = new Star[18];

    public static GameObject Canvas_Main_static;
    public static GameObject Canvas_Minigame_static;

//  new Star(0, 0, 9, Canvas_Quiz, cv_1),
    void Start()
    {
        Canvas_Main_static = Canvas_Main;
        Canvas_Minigame_static = Canvas_Minigame;
        
        information[0] = new Star() { 
            btn_id = 0, 
            status = 0, 
            category = 0, 
            target_canvas = Canvas_Article,
            target_star = cv_1,  
        };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
