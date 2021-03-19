using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        gameObject.transform.Rotate(0,5,0);
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            coins_player.coins+=1;
            other.GetComponent<coins_player>().text_coins.text = coins_player.coins.ToString();
            Debug.Log(coins_player.coins);
            //GameObject.FindGameObjectsWithTag("Player")
            Destroy(transform.parent.gameObject);
        }
    }
    
}
