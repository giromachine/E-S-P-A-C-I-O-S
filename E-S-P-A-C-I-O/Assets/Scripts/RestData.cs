using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    public GameObject Dom;
    public GameObject Lun;
    public GameObject Mar;
    public GameObject Mier;
    public GameObject Jue;
    public GameObject Vie;
    public GameObject Sab;
    public GameObject IsOnService;

    public GameObject textDisplay;
  
    public void StoreMailandPass()
    {
        Name = inputFieldName.GetComponent<TextMeshProUGUI>().text;
        Direc = inputFieldDirec.GetComponent<TextMeshProUGUI>().text;
        Tel = inputFieldTel.GetComponent<TextMeshProUGUI>().text;
    }
    public void StoreDaysAndService()
    {
        D = Dom.GetComponent<Toggle>();
        L = Lun.GetComponent<Toggle>();
        Ma = Mar.GetComponent<Toggle>();
        Mi = Mier.GetComponent<Toggle>();
        J = Jue.GetComponent<Toggle>();
        V = Vie.GetComponent<Toggle>();
        S = Sab.GetComponent<Toggle>();
        OnService = IsOnService.GetComponent<Toggle>();
    }
}
