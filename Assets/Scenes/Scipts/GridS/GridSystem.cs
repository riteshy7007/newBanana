using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem 
{
 private int _width;
private int _height;
float _cellSize ;
private GridObject[,] _gridObjectsarry;
    public GridSystem( int width, int height, float cellSize)
    {
        this._width = width;
        this._height = height;
        this._cellSize = cellSize;
        this._gridObjectsarry = new GridObject[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                 GridPosition gridPosition=new GridPosition(x, z);
                  _gridObjectsarry[x,z] =new GridObject(this, gridPosition);
            }
        }
    }

    public Vector3 GetWorldPosition(GridPosition gridPosition)
    {
        return new Vector3(gridPosition.x,0, gridPosition.z)*_cellSize;
    }
    
 public GridPosition GetGridPosition( Vector3 worldPosition)
 {
     int x = Mathf.FloorToInt(worldPosition.x / _cellSize);
     int z = Mathf.FloorToInt(worldPosition.z / _cellSize);
     return new GridPosition(x, z);

 }

  public void CreateDebugObjects(Transform debugPrefab){

        for (int x = 0; x < _width; x++)
        {
            for (int z = 0; z < _height; z++)
            {
                GridPosition gridPosition=new GridPosition(x, z);
                Transform debugObjTransform = GameObject.Instantiate(debugPrefab, GetWorldPosition(gridPosition), Quaternion.identity);
                 CreatedebugObject gridobjects =debugObjTransform.GetComponent<CreatedebugObject>();
                 gridobjects.SetGridobject(GetGridObject(gridPosition));
            }
        }
  }
  public GridObject GetGridObject(GridPosition gridPosition)
  {
     
   return _gridObjectsarry[gridPosition.x, gridPosition.z];
  }
}
