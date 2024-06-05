using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject 
{
    private GridPosition _gridPosition;
    private GridSystem _gridSystem;
    private Player _player;

    public GridObject(GridSystem gridSystem, GridPosition gridPosition)
    {
        _gridSystem = gridSystem;
        _gridPosition = gridPosition;
    }
     public override string ToString(){
        return _gridPosition.ToString()+"Player: "+_player;
     }
    
    public void SetPlayer(Player player){
        this._player = player;
    }
    public Player GetPlayer(){
        return _player;
    }
}
