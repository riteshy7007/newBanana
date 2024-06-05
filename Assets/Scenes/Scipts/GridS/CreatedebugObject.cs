using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreatedebugObject : MonoBehaviour
{
         private GridObject _gridObject;
         [SerializeField] private TextMeshPro textMeshPro;
     public void SetGridobject( GridObject gridObject){
        this._gridObject = gridObject;

     }
    private void Update()
    {
        textMeshPro.text = _gridObject.ToString();
    }
            

}
