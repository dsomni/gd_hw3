using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform FollowTarget;
    private float _fixedY;
    private Vector3 _offset;
    

    void Awake(){
        Vector3 initialPosition  = transform.position;
        _offset = initialPosition - FollowTarget.position;
        _fixedY = initialPosition.y;
    }
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Vector3 newPosition = FollowTarget.position + _offset;
        newPosition.y = _fixedY;
        transform.position = newPosition;
    }
}
