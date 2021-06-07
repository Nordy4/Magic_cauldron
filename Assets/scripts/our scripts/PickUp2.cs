using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp2 : MonoBehaviour
{
    public bool grabbed;
    public Vector3 rotationSpeed;

    private void OnTriggerEnter(Collider other){

        if((other.gameObject.CompareTag("Player2")) && !(PlayerManager.Instance.get_player2Grabbing())){
            grabbed = true;
            PlayerManager.Instance.set_player2Grabbing(true);
            this.transform.SetParent(other.transform, true);
        }
        
        if((other.gameObject.CompareTag("Cauldron")) && (grabbed == true)){
            PlayerManager.Instance.set_player2Grabbing(false);
        }

        if((other.gameObject.CompareTag("Table")) && (grabbed == true)){
            PlayerManager.Instance.set_player2Grabbing(false);
        }
        
    }

    void Update()
    {
        if(grabbed){
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}