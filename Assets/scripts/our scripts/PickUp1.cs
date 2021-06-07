using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public bool grabbed;
    public Vector3 rotationSpeed;


    private void OnTriggerEnter(Collider other){

        if((other.gameObject.CompareTag("Player1")) && !(PlayerManager.Instance.get_player1Grabbing())){
            grabbed = true;
            PlayerManager.Instance.set_player1Grabbing(true);
            this.transform.SetParent(other.transform, true);
        }
        
        if((other.gameObject.CompareTag("Cauldron")) && (grabbed == true)){
            PlayerManager.Instance.set_player1Grabbing(false);
        }

        if((other.gameObject.CompareTag("Table")) && (grabbed == true)){
            PlayerManager.Instance.set_player1Grabbing(false);
        }
        
    }

    void Update()
    {
        if(grabbed){
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
    
}

