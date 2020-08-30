using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LineScript2 : MonoBehaviour
{
    [SerializeField] int modoDibujo=0;
    //Linea
    private LineRenderer linea2;
    private Vector3 mousePos;
    public Material material;
    private int lineaActual = 0;
    private Vector3 startMousePos;

    [SerializeField]
    private Text distText;
    private float distance;
    //Mesa
    public GameObject mesa;
    public Camera mainCamera;
    private int mesaActual = 0;
    public float factorTam = 0.001f;
    private GameObject ultimoSpawn = null;
    private float primerTam;
    private float startX;
    private float startY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (modoDibujo == 1)
        {
            //Lineas
            if (Input.GetMouseButtonDown(0))
            {
                if (linea2 == null)
                {
                    crearLinea();
                }
                startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                startMousePos.z = 0;
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                linea2.SetPosition(0, mousePos);
                linea2.SetPosition(1, mousePos);
            }
            else if (Input.GetMouseButtonUp(0) && linea2)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                linea2.SetPosition(1, mousePos);
                linea2 = null;
                lineaActual++;
            }
            else if (Input.GetMouseButton(0) && linea2)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                linea2.SetPosition(1, mousePos);
                distance = (mousePos - startMousePos).magnitude;
                distText.text = distance.ToString("F2") + " metros";
            }
        }
        else if (modoDibujo == 2)
        {
            //Mesa
            if (Input.GetMouseButtonDown(0))
            {
                mesaActual++;
                Vector3 mesaPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
                mesaPos.z = 0;
                startX = mesaPos.x;
                startY = mesaPos.y;
                //mesa = new GameObject("Mesa" + mesaActual);
                ultimoSpawn=Instantiate(mesa, mesaPos, Quaternion.identity);
                //primerTam = ultimoSpawn.transform.localScale.x;
                //primerTam = ultimoSpawn.transform.localScale.y;
            }
            if (Input.GetMouseButton(0))
            {
                Vector2 size = ultimoSpawn.transform.localScale;
                size.x = primerTam + (Input.mousePosition.x - startX) * factorTam;
                size.y = primerTam + (Input.mousePosition.y - startY) * factorTam;
                ultimoSpawn.transform.localScale = size;
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
    }


