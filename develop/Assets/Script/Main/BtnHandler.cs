using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnHandler : MonoBehaviour
{
    public GameObject Canva_main;
    public GameObject Canva_minigame;
    public GameObject Panel_mission;
    public void Canva_minigame_control()
    {
        if(Canva_minigame.activeInHierarchy)
            Canva_minigame.SetActive(false);
        else
            Canva_minigame.SetActive(true);
        Panel_mission.SetActive(false);
    }

    public int Category;
    public GameObject[] btn_mission;
    public Button[] _btn_mission;
    public void selectCategory()
    {
        MainSystem.category = Category;
        Panel_mission.SetActive(true);
        for (int i = 0; i < 3; i++)
        {
            btn_mission[i].SetActive((MainSystem.status[MainSystem.category - 1, i] == 0) ? false : true);
            _btn_mission[i].enabled = ((MainSystem.status[MainSystem.category - 1, i] == 2) ? true : false);
        }
    }

    public int mission;
    public GameObject Canva_Article;
    public GameObject ArticleManager;
    public void selectMission()
    {
        MainSystem.mission = mission;
        Canva_minigame.SetActive(false);
        Canva_main.SetActive(false);
        Canva_Article.SetActive(true);
        ArticleManager.SetActive(true);
        // game_start();
    }

    public void selectStar()
    {
        MainSystem.is_placing = true;
    }

    public void debug()
    {
        Debug.Log(Canva_minigame.activeInHierarchy);
    }

}
