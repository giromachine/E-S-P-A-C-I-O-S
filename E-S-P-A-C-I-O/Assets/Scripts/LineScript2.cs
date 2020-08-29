using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineScript2 : MonoBehaviour
{
    private LineRenderer linea2;
    private Vector3 mousePos;
    public Material material;
    private int lineaActual = 0;
    private Vector3 startMousePos;
    [SerializeField]
    private Text distText;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            if (linea2 == null)
            {
                crearLinea();
            }
            startMousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            startMousePos.z = 0;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            linea2.SetPosition(0, mousePos);
            linea2.SetPosition(1, mousePos);
        } else if (Input.GetMouseButtonUp(0) && linea2)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            linea2.SetPosition(1, mousePos);
            linea2 = null;
            lineaActual++;
        } else if (Input.GetMouseButton(0) && linea2)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            linea2.SetPosition(1, mousePos);
            distance = (mousePos - startMousePos).magnitude;
            distText.text = distance.ToString("F2") + " metros";
        }
        
    
    }

    void crearLinea()
    {
        linea2 = new GameObject("Linea" + lineaActual).AddComponent<LineRenderer>();
        linea2.material = material;
        linea2.positionCount = 2;
        linea2.startWidth = 0.15f;
        linea2.endWidth = 0.15f;
        linea2.useWorldSpace = true;
        linea2.numCapVertices = 50;
    }
    



}
