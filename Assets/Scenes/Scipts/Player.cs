using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _targetPosition;

    // Update is called once per frame
    void Update()
    {
         if(Vector3.Distance(transform.position, _targetPosition) > 0.1f){
            Vector3 moveDirection = (_targetPosition - transform.position).normalized;
            float moveSpeed = 2f;
            transform.position += moveDirection *moveSpeed* Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Move(new Vector3(4, 0, 4));
            Debug.Log("Space key was pressed");
        }
    
    }

    private void Move( Vector3 targetPosition){
        this._targetPosition = targetPosition;


    }


    

}
