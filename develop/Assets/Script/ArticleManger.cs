using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArticleManger : MonoBehaviour
{
    public TextMeshProUGUI txt_title;
    public TextMeshProUGUI txt_content;

    void Start()
    {
        // JsonReader.section = JsonReader.information.game[MainSystem.category - 1];
        txt_title.text = JsonReader.information.game[MainSystem.category - 1].topic;
        txt_content.text = JsonReader.information.game[MainSystem.category - 1].about;
    }
}
