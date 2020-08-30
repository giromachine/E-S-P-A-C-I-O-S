using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegData : MonoBehaviour
{
    public string Mail;
    public string PassW;
    public GameObject inputFieldMail;
    public GameObject inputFieldPassW;

    private void Awake()
    {
        int RegDataCount = FindObjectsOfType<RegData>().Length;
        if (RegDataCount > 1)
        {
            DestroyRegData();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void DestroyRegData()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
    public void StoreMailandPass()
    {
        Mail = inputFieldMail.GetComponent<TextMeshProUGUI>().text;
        PassW = inputFieldPassW.GetComponent<TextMeshProUGUI>().text;
    }
}
