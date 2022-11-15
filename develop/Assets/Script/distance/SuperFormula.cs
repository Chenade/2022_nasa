using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SuperFormula : MonoBehaviour
{
    public  List<TMP_InputField> fields;
    public TMP_InputField apparentMagnitute;
    public TMP_Text Distance;
    float inputApparentMagnitute;
    public string theInput;
    public GameObject btn;

    public void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            fields[0].Select();
        }
    }

    public void cal()
    {
        float d = m_distance();
        Distance.text = "Distance = " + d.ToString() + " pc";
        btn.SetActive(true);
    }

    public float m_checkInputApparentMagnitute()
    {
        theInput = apparentMagnitute.text;
   
        if (float.TryParse(apparentMagnitute.text, out float result))
        {
            inputApparentMagnitute = result;
            return (inputApparentMagnitute);
        }
        else
        {
            // Debug.Log("Darling, this is not working");
            return (0);
        }
    }

    float m_distance()
    {
        float d;
        float am = (-19.5f);
        float ap = m_checkInputApparentMagnitute();
        float po = (ap - am + 5) /5;
        d = Mathf.Pow(10, po);
        return (d);
    }

}