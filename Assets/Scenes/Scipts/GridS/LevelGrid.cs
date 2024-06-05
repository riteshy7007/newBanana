using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    public static LevelGrid levelGridInstance { get; private set; }
     public GridSystem gridSystem;
     [SerializeField] private Transform debugPrefab;
  private void Awake()
  {
   if(levelGridInstance != null){
        Debug.LogError("There is more than one PlayerSelectionMachine in the scene"+transform+" XX"+levelGridInstance);
         Destroy(this);
     }

    gridSystem = new GridSystem(10, 10, 2f);
      gridSystem.CreateDebugObjects(debugPrefab);
  }

  public void SetPlayeratGridPosition(GridPosition gridPosition,Player player)
  {
      GridObject gridObject= gridSystem.GetGridObject(gridPosition);
        gridObject.SetPlayer(player);
        }
    
    public void GetPlayeratGridPosition(GridPosition gridPosition)
    {
         GridObject gridObject= gridSystem.GetGridObject(gridPosition);
         gridObject.GetPlayer();
    }
    public void  ClearPlayeratGridPosition(GridPosition gridPosition)
    {
        GridObject gridObject =gridSystem.GetGridObject(gridPosition);
        gridObject.SetPlayer(null);

    }

    public void PlayerMovedGridPosition(Player player,GridPosition oldGridPosition, GridPosition newGridPosition){

        ClearPlayeratGridPosition(oldGridPosition);
        SetPlayeratGridPosition(newGridPosition, player);
    }

     public GridPosition GetGridPosition(Vector3 worldPosition){

        return gridSystem.GetGridPosition(worldPosition);
     }








}
