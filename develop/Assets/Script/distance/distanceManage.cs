using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceManage : MonoBehaviour
{

    public GameObject lightcurve_cepheid;
    public GameObject forumla_cepheid;
    public GameObject image_cepheid;

    public GameObject lightcurve_c1;
    public GameObject lightcurve_c2;
    public GameObject lightcurve_c3;

    public GameObject lightcurve_sn;
    public GameObject forumla_sn;
    public GameObject image_sn;

    void Start()
    {
        MainSystem.category = 0;
        if (MainSystem.category == 0)
        {
            lightcurve_cepheid.SetActive(true);
            forumla_cepheid.SetActive(true);
            image_cepheid.SetActive(true);
            lightcurve_sn.SetActive(false);
            forumla_sn.SetActive(false);
            image_sn.SetActive(false);
        }
        else
        {
            lightcurve_cepheid.SetActive(false);
            forumla_cepheid.SetActive(false);
            image_cepheid.SetActive(false);
            lightcurve_sn.SetActive(true);
            forumla_sn.SetActive(true);
            image_sn.SetActive(true);
        }
    }

    void Update()
    {
        
    }

    public GameObject Canva_main;
    public GameObject Canva_game;

    public void Submit()
    {
        MainSystem.collected[MainSystem.category] += 1;
        MainSystem.mission = 0;
        Canva_game.SetActive(false);
        Canva_main.SetActive(true);
    }
}
