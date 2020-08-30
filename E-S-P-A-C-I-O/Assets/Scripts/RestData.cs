using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class RestData : MonoBehaviour
{
    public string Name;
    public string Direc;
    public string Tel;
    

    public GameObject inputFieldName;
    public GameObject inputFieldDirec;
    public GameObject inputFieldTel;
   

    public GameObject textDisplay;

    private void Awake()
    {
        int restDataCount = FindObjectsOfType<RestData>().Length;
        if(restDataCount > 1)
        {
            DestroyRestData();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void DestroyRestData()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    public void StoreRestInfo()
    {
        Name = inputFieldName.GetComponent<TextMeshProUGUI>().text;
        Direc = inputFieldDirec.GetComponent<TextMeshProUGUI>().text;
        Tel = inputFieldTel.GetComponent<TextMeshProUGUI>().text;
    }
    

}
