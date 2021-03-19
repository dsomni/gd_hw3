using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_checker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            Debug.Log("Finish");
            other.GetComponent<Movement>()._rigidbody.velocity = Vector3.zero;
            other.GetComponent<Movement>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
