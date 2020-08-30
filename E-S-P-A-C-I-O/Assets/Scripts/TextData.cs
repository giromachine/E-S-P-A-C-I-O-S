using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextData : MonoBehaviour
{
    public string Mail;
    public GameObject inputFieldMail;
    public GameObject inputFieldPassW;
    public GameObject textDisplay;
    public string PassW;

    public void StoreMailandPass()
    {
        Mail = inputFieldMail.GetComponent<TextMeshProUGUI>().text;
        PassW = inputFieldPassW.GetComponent<TextMeshProUGUI>().text;
    }

}
