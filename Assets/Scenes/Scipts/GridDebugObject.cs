using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridDebugObject : MonoBehaviour
{
    // Start is called before the first frame update
    private GridSystem  gridSystem;
    private GridObject gridObject;
    [SerializeField] private TextMeshPro textmeshpro;

     public void SetGridObject(GridObject gridObject){
        this.gridObject = gridObject;
     }

     void Update()
     {
        textmeshpro.text = gridObject.ToString();
     }
     



}
