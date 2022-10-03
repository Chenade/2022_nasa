using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class sim_ceiphed : MonoBehaviour
{
    public Slider _slider;
    public Image image;
    private float startPoint;
    RectTransform rt;

    public PostProcessVolume _pp;
    public Bloom _bloom;

    public GameObject Sphere;
    public GameObject chart;
    public GameObject finish;
    public Image[] curve;

    public Image[] d = new Image[10];
    void OnEnable()
    {
        // MainSystem.current_id = 3;
        if (MainSystem.current_id == 1)
        {
            curve[0].enabled  = (true);
            curve[1].enabled  = (false);
        }
        else
        {
            curve[0].enabled  = (false);
            curve[1].enabled  = (true);
        }
        _pp = Sphere.GetComponent<PostProcessVolume>();
        _pp.profile.TryGetSettings(out _bloom);
        rt = image.GetComponent<RectTransform>();
        float width = rt.rect.width;
        image.rectTransform.localScale = new Vector3(1, 1, 1);
        image.rectTransform.anchoredPosition = new Vector3(0, 0, 0);
        finish.SetActive(false);

        for (int i = 0 ; i < 10; i ++)
        {
            d[i] = Image.Instantiate(image);
            d[i].transform.SetParent(chart.transform);
            d[i].rectTransform.anchoredPosition = new Vector3(width * (i), 0, 0);
        }

        _slider.onValueChanged.AddListener((v) => {
            image.rectTransform.localScale = new Vector3(v / 4, 1, 1);
            image.rectTransform.anchoredPosition = new Vector3(0, 0, 0);
            float cw = width * (v / 4);
            float left = cw;
            for (int i = 0 ; i < 10; i ++)
                if(d[i]) Destroy(d[i]);
            for (int i = 0 ; i < 10; i ++)
            {
                d[i] = Image.Instantiate(image);
                d[i].transform.SetParent(chart.transform);
                d[i].rectTransform.localScale = new Vector3(v / 4, 1, 1);
                d[i].rectTransform.anchoredPosition = new Vector3(cw * (i + 1), 0, 0);
            }
            if (MainSystem.current_id == 1 && v == 3f || MainSystem.current_id == 3 && v == 5f)
                finish.SetActive(true);
            // else if (MainSystem.current_id == 3 && v == 5f)
                // finish.SetActive(true);
            else
                finish.SetActive(false);
        });
    }

    // float intensity = 40f;
    // float delta = -1f;

    void Update()
    {
        // if (intensity >= 40f || intensity <= 0f)
        //     delta *= -1;
        // intensity += 1f * delta;

        // _bloom.intensity.value = intensity;
    }

    public GameObject Canva_main;
    public GameObject Canva_sim;

    public void Submit()
    {
        for (int i = 0 ; i < 10; i ++)
            if(d[i]) Destroy(d[i]);
        StarSystem.level_pass();
        MainSystem.mission = 3;
        MainSystem.is_mission = false;
        StarSystem.information[MainSystem.current_id].target_star.SetActive(true);
        Canva_sim.SetActive(false);
        Canva_main.SetActive(true);
    }
}
