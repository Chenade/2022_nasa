using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnHandler : MonoBehaviour
{
    public GameObject Canva_main;
    public GameObject Canva_minigame;

    public void Canva_minigame_control()
    {
        if(Canva_minigame.activeInHierarchy)
            Canva_minigame.SetActive(false);
        else
            Canva_minigame.SetActive(true);
        // Panel_mission.SetActive(false);
    }

    // public GameObject[] btn_mission;
    // public Button[] _btn_mission;
    // public void selectCategory()
    // {
    //     MainSystem.category = Category;
    //     Panel_mission.SetActive(true);
    //     for (int i = 0; i < 3; i++)
    //     {
    //         btn_mission[i].SetActive((MainSystem.status[MainSystem.category - 1, i] == 0) ? false : true);
    //         _btn_mission[i].enabled = ((MainSystem.status[MainSystem.category - 1, i] == 2) ? true : false);
    //     }
    // }

    // public int mission;
    // public GameObject Canva_Article;
    // // public GameObject ArticleManager;
    // public void selectMission()
    // {
    //     MainSystem.mission = mission;
    //     Canva_minigame.SetActive(false);
    //     Canva_main.SetActive(false);
    //     Canva_Article.SetActive(true);
    //     // ArticleManager.SetActive(true);
    //     // game_start();
    // }

    // public void selectStar()
    // {
    //     MainSystem.is_placing = true;
    // }

    public void debug()
    {
        Debug.Log(Canva_minigame.activeInHierarchy);
    }

    public int Category;
    public GameObject Canva_Article;
    public GameObject ArticleManager;
    public GameObject[] Canva_Simulator;
    public GameObject Canva_Distance;

    public void earn_star(int id)
    {
        MainSystem.is_mission = true;
        MainSystem.current_id = id;
        MainSystem.category = StarSystem.information[id].category;
        StarSystem.Canvas_Main_static.SetActive(false);
        StarSystem.Canvas_Minigame_static.SetActive(false);
        StarSystem.information[id].target_canvas.SetActive(true);
    }

    public GameObject nightsky;
    public GameObject nightsky_empty;
    public void switch_view()
    {
        if (nightsky.activeInHierarchy)
        {
            nightsky.SetActive(false);
            nightsky_empty.SetActive(true);
        }
        else
        {
            nightsky.SetActive(true);
            nightsky_empty.SetActive(false);
        }
    }

}
