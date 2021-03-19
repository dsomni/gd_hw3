using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 1f;
    public Vector3 Direction1 = Vector3.forward;
    public Vector3 Direction2 = Vector3.left;
    public int _directionIndex;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            if (_directionIndex == 0){
                _directionIndex = 1;
            }
            else{
                _directionIndex = 0;
            }
        }
    }
    private void OnDisable(){
        Vector3 velocity = Vector3.zero;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }

    private Vector3 GetDirection(){
        if (_directionIndex == 0){
            return Direction1;
            }
        return Direction2;
    
    }

    private void FixedUpdate(){
        Vector3 velocity = GetDirection() * Speed;
        Speed+=0.05f;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }

}