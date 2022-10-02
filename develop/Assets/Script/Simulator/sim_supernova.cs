using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sim_supernova : MonoBehaviour
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
        MainSystem.collected[MainSystem.category] += 1;
        MainSystem.mission = 3;
        Canva_sim.SetActive(false);
        Canva_main.SetActive(true);
    }
}
