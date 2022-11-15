using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sim_supernova : MonoBehaviour
{

    public GameObject finish;
    public GameObject a_big;
    public GameObject a_small;
    public Slider _slider;

    public void OnEnable()
    {
        _slider.value = 0;
        a_small.transform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
        a_big.transform.localScale = new Vector3( 3f,  3f,  3f);
        finish.SetActive(false);
    }

    float scale_delta = 1.7f;
    float scale_delta2 = 3f;
    public void btn_Burst()
    {
        _slider.value += 5;
        if(_slider.value >= 100f)
        {
            finish.SetActive(true);
            StarSystem.level_pass();
        }
        else{
            scale_delta += 0.02f;
            scale_delta2 -= 0.02f;
            a_small.transform.localScale = new Vector3(scale_delta, scale_delta, scale_delta);
            a_big.transform.localScale = new Vector3(scale_delta2, scale_delta2, scale_delta2);

        }

        // a_big.transform.Scale(a_big.transform.Scale - scale_delta);
    }

    public GameObject Canva_main;
    public GameObject Canva_sim;

    public void Submit()
    {
        MainSystem.mission = 3;
        MainSystem.is_mission = false;
        StarSystem.information[MainSystem.current_id].target_star.SetActive(true);
        Canva_sim.SetActive(false);
        Canva_main.SetActive(true);
    }
}
