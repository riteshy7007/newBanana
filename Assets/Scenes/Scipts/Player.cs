using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _targetPosition;
    [SerializeField] private Animator _animator;
    private GridPosition _gridPosition;

    private  void Awake()
    {
        _targetPosition = transform.position;
    }
    void Start()
    {
       _gridPosition = LevelGrid.levelGridInstance.GetGridPosition(transform.position);
        LevelGrid.levelGridInstance.SetPlayeratGridPosition(_gridPosition, this);
    }   

    // Update is called once per frame
    void Update()
    
    {
         if(Vector3.Distance(transform.position, _targetPosition) > 0.1f){
            Vector3 moveDirection = (_targetPosition - transform.position).normalized;
            float moveSpeed = 2f;
            transform.position += moveDirection *moveSpeed* Time.deltaTime;
            float rotationspeed = 10f;
            transform.forward =  Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * rotationspeed);

           
                _animator.SetBool("IsWalk", true);
            
        }else{
                _animator.SetBool("IsWalk", false);
            }
        GridPosition newGridPosition = LevelGrid.levelGridInstance.GetGridPosition(transform.position);
        if (_gridPosition != newGridPosition){
            LevelGrid.levelGridInstance.PlayerMovedGridPosition(_gridPosition, newGridPosition, this);
           _gridPosition = newGridPosition;
        }
        
    
    }

    public void Move( Vector3 targetPosition){
        this._targetPosition = targetPosition;


    }


    

}
