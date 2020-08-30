using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;

public class gridManager : MonoBehaviour
{
    [SerializeField]
    private int rows = datosDimension.ancho;
    [SerializeField]
    private int cols = datosDimension.largo;
    [SerializeField]
    private float tileSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("Tile"));

        tileSize = (rows * cols) / (rows*cols)*0.5f;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }

        Destroy(referenceTile);

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector3(-gridW / 2 + tileSize / 2, gridH/2 - tileSize / 2,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
