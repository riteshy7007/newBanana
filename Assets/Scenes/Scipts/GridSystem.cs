using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem 
{
    //create a grid system
    private int _width;
    private int _height;
    private float _cellSize;
    public GridSystem(int width, int height, float cellSize)
    {
        this._width = width;
        this._height= height;
        this._cellSize= cellSize;


        for (int x = 0; x < _width; x++)
        {
            for (int z = 0; z < _height; z++)
            {
                Debug.DrawLine(GetWorldPosition(x,z), GetWorldPosition(x,z) + Vector3.right*.2f, Color.white, 100f);
                
            }
        }
    }
    public Vector3 GetWorldPosition(int x, int z)
    {
        return new Vector3(x,0,z) * _cellSize;
    }

}
