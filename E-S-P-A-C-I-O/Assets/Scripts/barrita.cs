using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barrita : MonoBehaviour {

    public string busqueda;
    public GameObject inputField;
    public GameObject textDisplay;

    public void barrita.StoreName()
    {
        busqueda = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "No hay coincidencias con" + busqueda;
    }
}
