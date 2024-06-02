using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectionMachine : MonoBehaviour
{

    
    [SerializeField]private Player _selectedPlayer;
    [SerializeField] private LayerMask _playerlayerMask;


    

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
                _selectedPlayer = player;
                return true;
            }
        }return false;
    }
    
}
