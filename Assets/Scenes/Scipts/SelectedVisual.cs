using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedVisual : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Player _selectedPlayer;
    [SerializeField] private MeshRenderer _meshRenderer;

    void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    void  Start()
    {
        PlayerSelectionMachine.instance.OnPlayerSelected += Instance_OnPlayerSelected;
        UpdateVisual();
    }
     private void Instance_OnPlayerSelected(object sender, System.EventArgs e){
        UpdateVisual();   
     }

     private void UpdateVisual(){
         Player selectedPlayer = PlayerSelectionMachine.instance.GetSelectedPlayer();
            if(selectedPlayer == _selectedPlayer){
                _meshRenderer.enabled = true;
            }else{
                _meshRenderer.enabled = false;
            }
         
         }
     
    

}
