using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectionMachine : MonoBehaviour
{


    [SerializeField]private Player _selectedPlayer;
    [SerializeField] private LayerMask _playerlayerMask;
   public event EventHandler OnPlayerSelected;



    

    // Update is called once per frame
void Update(){
        if(Input.GetMouseButtonDown(0)){
            
           TryPlayerSlection();
            _selectedPlayer.Move(MouseWorld.GetPosition());
              
           
            

        }
    }

    private bool  TryPlayerSlection(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit,float.MaxValue ,_playerlayerMask)){
            if(hit.transform.TryGetComponent<Player>(out Player player)){
                SetSlectedPlayer(player);
                

                return true;
            }
        }return false;
    }
     private void SetSlectedPlayer(Player player){
        _selectedPlayer = player;
        OnPlayerSelected?.Invoke(this, EventArgs.Empty);
       
     }
      public Player GetSelectedPlayer(){
        return _selectedPlayer;
      }




    
}
