using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableManager : MonoBehaviour
{

    public GameObject poties; 

    private void OnTriggerEnter(Collider other){
        other.transform.SetParent(poties.transform, true);

    }
}
