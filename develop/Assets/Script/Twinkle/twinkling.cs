using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twinkling : MonoBehaviour
{
    public Light _light;
    public float intensity = 1f;
    public float delta = -1;
    public float step = 0.01f;
    public int star_id;

    public float timestamp;

    void Start()
    {
        // StartCoroutine(twinkle());
        // star_id = 0;
        // intensity = 1f;
        timestamp = 0f;
        intensity = JSONStar.information.data[star_id].curve[0].y;
        _light.range = intensity;
    }

    void FixedUpdate()
    {
        timestamp += MainSystem.time_rate * Time.deltaTime;

        for(int i = 1; i < JSONStar.information.data[star_id].curve.Length; i ++)
        {
            // Debug.Log(JSONStar.information.data[star_id].curve[i].x + " => " + Mathf.Abs(timestamp - JSONStar.information.data[star_id].curve[i].x));

            if (Mathf.Abs(timestamp - JSONStar.information.data[star_id].curve[i].x) < 0.5f)
            {
                intensity = JSONStar.information.data[star_id].curve[i].y;
                // Debug.Log(intensity);
                _light.range = intensity;
                break ;
            }
        }
        if (timestamp > JSONStar.information.data[star_id].curve[JSONStar.information.data[star_id].curve.Length - 1].x)
        {
            timestamp = 0;
            intensity = JSONStar.information.data[star_id].curve[0].y;
        }
        // _light.range = intensity;

    }

    // IEnumerator twinkle()
    // {
    //     while (true)
    //     {
    //         // Debug.Log("Started Coroutine at timestamp : " + Time.time);

    //         // stage_2.SetActive(false);
    //         // stage_1.SetActive(true);
    //         // Debug.Log(MainSystem.delta_time);
    //         stage_2.transform.localScale += new Vector3(1f, 1f, 1f);
    //         yield return new WaitForSeconds(5);

    //         // stage_1.SetActive(false);
    //         // stage_2.SetActive(true);
    //         // Debug.Log(MainSystem.delta_time);
    //         stage_2.transform.localScale -= new Vector3(1f, 1f, 1f);
    //         yield return new WaitForSeconds(5);
    //         // while(Time.time <= MainSystem.delta_time) ;

    //     }
       
    // }
}
