using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarSystem : MonoBehaviour
{

    [System.Serializable]
    public class Star
    {
        public int btn_id;
        public Button btn;
        public int status;
        public int category;
        public GameObject target_canvas;
        public GameObject target_star;
        public Sprite enabled;
        public Sprite disabled;
    }

    public GameObject   Canvas_Main;
    public GameObject   Canvas_Minigame;
    public GameObject   Canvas_Article;
    public GameObject   Canvas_Quiz;
    public GameObject[] Canva_Simulator;
    public GameObject   Canvas_Distance;

    public GameObject[]   cv;
    public GameObject[]   dn;
    public GameObject[]   sn;
    public GameObject[]   eb;
    public GameObject[]   el;

    public Button[] btn;
    public Sprite[] enabled_icon;
    public Sprite[] disabled_icon;
    

    public static Star[] information = new Star[18];

    public static GameObject Canvas_Main_static;
    public static GameObject Canvas_Minigame_static;

//  new Star(0, 0, 9, Canvas_Quiz, cv_1),
    void Start()
    {
        Canvas_Main_static = Canvas_Main;
        Canvas_Minigame_static = Canvas_Minigame;
        
        information[0] = new Star() { btn_id = 0,  btn = btn[0], status = 0, category = 0, target_canvas = Canvas_Article, target_star = cv[0],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[1] = new Star() { btn_id = 1,  btn = btn[1], status = 0, category = 0, target_canvas = Canva_Simulator[0], target_star = cv[1],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[2] = new Star() { btn_id = 2,  btn = btn[2], status = 0, category = 0, target_canvas = Canvas_Distance, target_star = cv[2],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[3] = new Star() { btn_id = 3,  btn = btn[3], status = 0, category = 0, target_canvas = Canvas_Article, target_star = cv[3],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[4] = new Star() { btn_id = 4,  btn = btn[3], status = 0, category = 0, target_canvas = Canva_Simulator[0], target_star = cv[4],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[5] = new Star() { btn_id = 5,  btn = btn[3], status = 0, category = 0, target_canvas = Canvas_Distance, target_star = cv[5],  enabled = enabled_icon[0], disabled = disabled_icon[0]};

        information[6] = new Star() { btn_id = 6,  btn = btn[4], status = 0, category = 1, target_canvas = Canvas_Article, target_star = dn[0],  enabled = enabled_icon[0], disabled = disabled_icon[0]};

        information[7] = new Star() { btn_id = 7,  btn = btn[5], status = 0, category = 2, target_canvas = Canvas_Article, target_star = sn[0],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[8] = new Star() { btn_id = 8,  btn = btn[6], status = 0, category = 2, target_canvas = Canva_Simulator[1], target_star = sn[1],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[9] = new Star() { btn_id = 9,  btn = btn[7], status = 0, category = 2, target_canvas = Canvas_Distance, target_star = sn[2],  enabled = enabled_icon[0], disabled = disabled_icon[0]};

        information[10] = new Star() { btn_id = 10, btn = btn[8], status = 0, category = 3, target_canvas = Canvas_Article, target_star = eb[0],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[11] = new Star() { btn_id = 11, btn = btn[9], status = 0, category = 3, target_canvas = Canva_Simulator[2], target_star = eb[1],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[12] = new Star() { btn_id = 12, btn = btn[10], status = 0, category = 3, target_canvas = Canvas_Article, target_star = eb[2],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[13] = new Star() { btn_id = 13, btn = btn[11], status = 0, category = 3, target_canvas = Canva_Simulator[2], target_star = eb[3],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[14] = new Star() { btn_id = 14, btn = btn[11], status = 0, category = 3, target_canvas = Canvas_Article, target_star = eb[4],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[15] = new Star() { btn_id = 15, btn = btn[11], status = 0, category = 3, target_canvas = Canva_Simulator[2], target_star = eb[5],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        
        information[16] = new Star() { btn_id = 16, btn = btn[12], status = 0, category = 4, target_canvas = Canvas_Article, target_star = el[0],  enabled = enabled_icon[0], disabled = disabled_icon[0]};
        information[17] = new Star() { btn_id = 17, btn = btn[13], status = 0, category = 4, target_canvas = Canva_Simulator[3], target_star = el[1], enabled = enabled_icon[0], disabled = disabled_icon[0]}; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
