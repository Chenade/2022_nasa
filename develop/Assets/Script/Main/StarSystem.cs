using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StarSystem : MonoBehaviour
{

    [System.Serializable]
    public class Star
    {
        public int btn_id;
        public Button btn;
        public string name;
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
    // Transform textObject;

//  new Star(0, 0, 9, Canvas_Quiz, cv_1),
    void Start()
    {
        Canvas_Main_static = Canvas_Main;
        Canvas_Minigame_static = Canvas_Minigame;
        int i = 0;
        i = 0; information[i] = new Star() { btn_id = 0,  btn = btn[i], name = "QZ Normae", status = 0, category = 0, target_canvas = Canvas_Article, target_star = cv[0],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 1; information[i] = new Star() { btn_id = 1,  btn = btn[i], name = "R Trianguli Austrlis", status = 0, category = 0, target_canvas = Canva_Simulator[0], target_star = cv[1],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 2; information[i] = new Star() { btn_id = 2,  btn = btn[i], name = "R Muscae", status = 0, category = 0, target_canvas = Canvas_Distance, target_star = cv[2],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 3; information[i] = new Star() { btn_id = 3,  btn = btn[i], name = "UU Muscae", status = 0, category = 0, target_canvas = Canva_Simulator[0], target_star = cv[3],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 4; information[i] = new Star() { btn_id = 4,  btn = btn[i], name = "BZ Tucanae", status = 0, category = 0, target_canvas = Canvas_Article, target_star = cv[4],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 5; information[i] = new Star() { btn_id = 5,  btn = btn[i], name = "V636", status = 0, category = 0, target_canvas = Canvas_Distance, target_star = cv[5],  enabled = enabled_icon[i], disabled = disabled_icon[i]};

        i = 6; information[i] = new Star() { btn_id = 6,  btn = btn[i], name = "TV Corvi", status = 0, category = 1, target_canvas = Canvas_Article, target_star = dn[0],  enabled = enabled_icon[i], disabled = disabled_icon[i]};

        i = 7; information[i] = new Star() { btn_id = 7,  btn = btn[i], name = "SN 1972E", status = 0, category = 2, target_canvas = Canvas_Article, target_star = sn[0],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 8; information[i] = new Star() { btn_id = 8,  btn = btn[i], name = "SN 1006", status = 0, category = 2, target_canvas = Canva_Simulator[1], target_star = sn[1],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 9; information[i] = new Star() { btn_id = 9,  btn = btn[i], name = "SN 2020", status = 0, category = 2, target_canvas = Canvas_Distance, target_star = sn[2],  enabled = enabled_icon[i], disabled = disabled_icon[i]};

        i = 10; information[i] = new Star() { btn_id = 10, btn = btn[i], name = "KZ pavonis", status = 0, category = 3, target_canvas = Canvas_Article, target_star = eb[0],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 11; information[i] = new Star() { btn_id = 11, btn = btn[i], name = "AR pavonis", status = 0, category = 3, target_canvas = Canvas_Article, target_star = eb[1],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 12; information[i] = new Star() { btn_id = 12, btn = btn[i], name = "V681", status = 0, category = 3, target_canvas = Canva_Simulator[3], target_star = eb[2],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 13; information[i] = new Star() { btn_id = 13, btn = btn[i], name = "VZ Librae", status = 0, category = 3, target_canvas = Canvas_Article, target_star = eb[3],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 14; information[i] = new Star() { btn_id = 14, btn = btn[i], name = "54 VirginisA", status = 0, category = 3, target_canvas = Canvas_Article, target_star = eb[4],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 15; information[i] = new Star() { btn_id = 15, btn = btn[i], name = "V Crateris", status = 0, category = 3, target_canvas = Canvas_Article, target_star = eb[5],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        
        i = 16; information[i] = new Star() { btn_id = 16, btn = btn[i], name = "Spica", status = 0, category = 4, target_canvas = Canvas_Article, target_star = el[0],  enabled = enabled_icon[i], disabled = disabled_icon[i]};
        i = 17; information[i] = new Star() { btn_id = 17, btn = btn[i], name = "V831", status = 0, category = 4, target_canvas = Canva_Simulator[4], target_star = el[1], enabled = enabled_icon[i], disabled = disabled_icon[i]}; 
    }

    public static void level_pass()
    {
        switch(MainSystem.current_id)
        {
            // case (3):
            // case (6):
            // case (9):
            // case (13):
            // case (17):
            //     break ;
            default :
                information[MainSystem.current_id + 1].btn.image.overrideSprite = information[MainSystem.current_id + 1].disabled;
                information[MainSystem.current_id + 1].btn.interactable = true;
                break ;
        }
        information[MainSystem.current_id].btn.image.overrideSprite = information[MainSystem.current_id].enabled;
        Transform starName = information[MainSystem.current_id].target_star.transform.Find("StarName");
        if (starName)
            starName.GetComponent<TextMeshPro>().text = information[MainSystem.current_id].name;
    }
}
