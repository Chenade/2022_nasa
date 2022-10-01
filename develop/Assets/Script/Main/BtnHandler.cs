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
    public void selectCategory()
    {
        MainSystem.category = Category;
        Panel_mission.SetActive(true);
    }

    public int mission;
    public GameObject Canva_Article;
    public GameObject Canva_Quiz;
    public void selectMission()
    {
        MainSystem.mission = mission;
        Canva_Article.SetActive(true);
        Canva_minigame.SetActive(false);
        Canva_main.SetActive(false);
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
