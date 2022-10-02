using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public  List<TMP_InputField> fields;
    public TMP_InputField period;
    public TMP_InputField apparentMagnitute;
    public TMP_InputField apparentMagnitute_;
    public TMP_Text AM;
    public TMP_Text Distance; 
    public TMP_Text Distance_; 
    // public string theInput;
    public GameObject btn;

    void OnEnable()
    {
        period.text = "";
        apparentMagnitute.text = "";
        apparentMagnitute_.text = "";
        AM.text = "0";
        Distance.text = "0";
        Distance_.text = "0";
        btn.SetActive(false);

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
        StarSystem.level_pass();
        MainSystem.mission = 0;
        MainSystem.is_mission = false;
        StarSystem.information[MainSystem.current_id].target_star.SetActive(true);
        Canva_game.SetActive(false);
        Canva_main.SetActive(true);
    }
}
