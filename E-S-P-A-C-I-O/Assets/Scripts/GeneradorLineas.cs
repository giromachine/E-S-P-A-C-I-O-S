using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GeneradorLineas : MonoBehaviour
{
    public GameObject lineGen;
    Lineas linea;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 dondeGen = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
            GameObject lineaActual = Instantiate(lineGen, dondeGen, transform.rotation);
            linea = lineaActual.GetComponent<Lineas>();
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            linea = null;
        }

        if(linea != null)
        {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            linea.DibujarLinea(mousePos);
        }
    }
}
