using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArticleManger : MonoBehaviour
{
    public TextMeshProUGUI txt_title;
    public TextMeshProUGUI txt_content;

    public GameObject btn_pre;
    public GameObject btn_next;
    public GameObject btn_start;

    public static int page;
    public static string[] content;

    void OnEnable()
    {
        btn_pre.SetActive(false);
        btn_next.SetActive(false);
        btn_start.SetActive(false);
        page = 0;

        content = JsonReader.information.game[MainSystem.category].about;
        txt_title.text = JsonReader.information.game[MainSystem.category].topic;
        txt_content.text = content[page];

        if (JsonReader.information.game[MainSystem.category].about.Length > 1)
            btn_next.SetActive(true);
    }
}
