using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{

    public TextAsset jsonFile;

    [System.Serializable]
    public class Quiz
    {
        public string question;
        public string[] answers;
        public int correct;
        public bool is_selected;
    }

    [System.Serializable]
    public class Info
    {
        public string topic;
        public string about;
        public Quiz[] members;
    }

    [System.Serializable]
    public class InfoList
    {
        public Info[] game;
    }

    public static InfoList information = new InfoList();
    public static Info section;

    void Start()
    {
        information = JsonUtility.FromJson<InfoList>(jsonFile.text);
    }
}
