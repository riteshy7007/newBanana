using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWorld : MonoBehaviour
{

private static MouseWorld instance;
[SerializeField] private LayerMask layerMask; 

void Awake(){

    instance = this;
}
     
    // Start is called before the first frame update
   



private  static Vector3 GetPosition(){
     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, instance.layerMask);
    return hit.point;
    
   }




}
