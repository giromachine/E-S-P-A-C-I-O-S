using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class datosDimension : MonoBehaviour
{
    public static int  ancho;
    public static int largo;


    public InputField inputAncho;
    public InputField inputLargo;

    public void storeDims()
    {

        ancho = int.Parse(inputAncho.text);

        largo = int.Parse(inputLargo.text);
    }

    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
