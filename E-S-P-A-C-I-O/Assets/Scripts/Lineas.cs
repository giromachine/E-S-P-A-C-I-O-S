using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lineas : MonoBehaviour
{
    LineRenderer linea;

    List<Vector2> points;
    Vector2 lastPoint;

    private void Awake()
    {
        linea = GetComponent<LineRenderer>();
    }

    public void DibujarLinea(Vector2 posMouse)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            DibujarPunto(posMouse);
            return;
        }

        if (Vector2.Distance(lastPoint, posMouse) >= 0.5f)
        {
            DibujarPunto(posMouse);
        }
    }
    void DibujarPunto(Vector2 point)
    {
        points.Add(point);
        linea.positionCount = points.Count;
        linea.SetPosition(points.Count - 1, point);
        lastPoint = point;
    }
}
