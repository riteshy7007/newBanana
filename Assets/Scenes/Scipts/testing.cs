using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    private GridSystem  gridSystem;
    [SerializeField] private Transform debugprefab;
    void Start()
    {
         gridSystem =new GridSystem(10,10,2f);
         gridSystem.CreateDebugObjects(debugprefab);

      
       Debug.Log(new GridPosition(5,7));
    }
    void Update()
    {
        Debug.Log(gridSystem.GetGridPosition(MouseWorld.GetPosition()));
        
    }
}
