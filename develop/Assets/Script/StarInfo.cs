using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarInfo : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    GameObject dash;
    
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.name.Contains("cv") || hit.collider.name.Contains("sn") || hit.collider.name.Contains("eb") || hit.collider.name.Contains("el"))
            {
                Transform starName = hit.collider.transform.Find("Canvas");
                if (starName)
                {
                    dash = starName.gameObject;
                    dash.SetActive(true);
                }
                // print(hit.collider.name);
            }
            else
            {
                if(dash)
                {
                    dash.SetActive(false);
                    dash = null;
                }
            }
        }
        else
        {
            if(dash)
            {
                dash.SetActive(false);
                dash = null;
            }
        }
    }
}
