using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem 
{
    //create a grid system
    private int _width;
    private int _height;
    private float _cellSize;
    private GridObject[,] _gridObjectsarray;
    public GridSystem(int width, int height, float cellSize)
    {
        this._width = width;
        this._height= height;
        this._cellSize= cellSize;
        _gridObjectsarray = new GridObject[_width, _height];


        for (int x = 0; x < _width; x++)
        {
            for (int z = 0; z < _height; z++)
            {
                GridPosition  gridPosition=new GridPosition(x,z);
                _gridObjectsarray[x, z] = new GridObject(this, gridPosition);
                
            }
        }
    }
    public Vector3 GetWorldPosition(int x, int z)
    {
        return new Vector3(x,0,z) * _cellSize;
    }

    public GridPosition GetGridPosition(Vector3 worldPosition)
    {
        return new GridPosition(
            Mathf.FloorToInt(worldPosition.x/_cellSize),
             Mathf.FloorToInt(worldPosition.z/_cellSize));
    }


public void CreateDebugObjects(Transform debugprefab)
{
    for (int x = 0; x < _width; x++)
    {
        for (int z = 0; z < _height; z++)
        {
          GameObject.Instantiate(debugprefab, GetWorldPosition(x,z), Quaternion.identity);
        }
    }
}
}
