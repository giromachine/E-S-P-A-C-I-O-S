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
    public bool D;
    public bool L;
    public bool Ma;
    public bool Mi;
    public bool J;
    public bool V;
    public bool S;
    public bool OnService;

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
    public void Dom(bool tog)
    {
        D = tog;
    }
    public void Lun(bool tog)
    {
        L = tog;
    }
    public void Mar(bool tog)
    {
        Ma = tog;
    }
    public void Mier(bool tog)
    {
        Mi = tog;
    }
    public void Jue(bool tog)
    {
        J = tog;
    }
    public void Vier(bool tog)
    {
        V = tog;
    }
    public void Sab(bool tog)
    {
        S = tog;
    }
    public void InService(bool tog)
    {
        OnService = tog;
    }

}
