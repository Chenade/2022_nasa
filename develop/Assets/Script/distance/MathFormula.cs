using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MathFormula : MonoBehaviour
{
    public  List<TMP_InputField> fields;
    public TMP_InputField period;
    public TMP_InputField apparentMagnitute;
    public TMP_Text AM;
    public TMP_Text Distance; 
    float inputPeriod;
    float inputApparentMagnitute;
    public string theInput;
    public GameObject btn;

    public void Update() 
    {
        int ans = 0;
        // if (Input.GetKeyUp(KeyCode.Alpha0)||Input.GetKeyUp(KeyCode.Alpha1)||Input.GetKeyUp(KeyCode.Alpha2)||Input.GetKeyUp(KeyCode.Alpha3)||Input.GetKeyUp(KeyCode.Alpha4)||Input.GetKeyUp(KeyCode.Alpha5)||Input.GetKeyUp(KeyCode.Alpha6)||Input.GetKeyUp(KeyCode.Alpha7)||Input.GetKeyUp(KeyCode.Alpha8)||Input.GetKeyUp(KeyCode.Alpha9)) 
        // {
        //     float d = distance();
        //     Distance.text = d.ToString();
        //     if (absoluteMagnitude() == -3.220324f && distance() == 271.6845f) btn.SetActive(true);
        // }
        // if (Input.GetKeyUp(KeyCode.Alpha0)||Input.GetKeyUp(KeyCode.Alpha1)||Input.GetKeyUp(KeyCode.Alpha2)||Input.GetKeyUp(KeyCode.Alpha3)||Input.GetKeyUp(KeyCode.Alpha4)||Input.GetKeyUp(KeyCode.Alpha5)||Input.GetKeyUp(KeyCode.Alpha6)||Input.GetKeyUp(KeyCode.Alpha7)||Input.GetKeyUp(KeyCode.Alpha8)||Input.GetKeyUp(KeyCode.Alpha9)) 
        // {
        //     float am = absoluteMagnitude();
        //     AM.text = am.ToString();
        //     if (absoluteMagnitude() == -3.220324f && distance() == 271.6845f) btn.SetActive(true);
        // }
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            fields[1].Select();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            fields[0].Select();
        }
    }

    public void cal()
    {
        float d = distance();
        Distance.text = d.ToString();
        float am = absoluteMagnitude();
        AM.text = am.ToString();
        if (AM.text == "-3.220324" && Distance.text == "271.6845") btn.SetActive(true);
    }
 
    public float checkInputperiod()
    {
        theInput = period.text;
             
        if (float.TryParse(period.text, out float result))
        {
            inputPeriod = result;
            return (inputPeriod);
        }
        else
        {
            // Debug.Log("Darling, this is not working");
            return (0);
        }
    }

    public float checkInputApparentMagnitute()
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

    float absoluteMagnitude()
    {
        float ma;
        float p = checkInputperiod();
        float l = Mathf.Log10(p);

        ma = -2.4f * (l - 1f) - 4.1f;
        return(ma);
    }

    float distance()    {
        float d;
        float am = absoluteMagnitude();
        float ap = checkInputApparentMagnitute();
        float po = (ap - am + 5) /5;
        d = Mathf.Pow(10, po);
        return (d);
    }

}
