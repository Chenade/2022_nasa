using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sim_el : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Canva_main;
    public GameObject Canva_sim;

    public void Submit()
    {
        StarSystem.level_pass();
        MainSystem.mission = 3;
        MainSystem.is_mission = false;
        StarSystem.information[MainSystem.current_id].target_star.SetActive(true);
        Canva_sim.SetActive(false);
        Canva_main.SetActive(true);
    }
}

