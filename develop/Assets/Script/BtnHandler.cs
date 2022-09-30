using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnHandler : MonoBehaviour
{
    public GameObject Canva_minigame;
    public GameObject Panel_mission;
    public void Canva_minigame_control()
    {
        if(Canva_minigame.active)
            Canva_minigame.SetActive(false);
        else
            Canva_minigame.SetActive(true);
        Panel_mission.SetActive(false);
    }

    public int Category;
    public void selectCategory()
    {
        MainSystem.category = Category;
        Debug.Log(Panel_mission.active);
        Panel_mission.SetActive(true);
    }

    public int mission;
    public GameObject Canva_Quiz;
    public void selectMission()
    {
        MainSystem.mission = mission;
        switch (mission)
        {
            case 1:
                Canva_Quiz.SetActive(true);
                Canva_minigame.SetActive(false);
                break ;
        }
        
    }

    public void debug()
    {
        Debug.Log(MainSystem.category);
    }

}
