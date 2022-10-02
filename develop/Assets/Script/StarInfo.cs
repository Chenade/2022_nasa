using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarInfo : MonoBehaviour
{
     Ray ray;
     RaycastHit hit;
     public GameObject dash;
     
     void Update()
     {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.name.Contains("cv"))
                print(hit.collider.name);

        }
     }
}
