using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableManager : MonoBehaviour
{
    public GameObject entity;

    private void OnTriggerEnter(Collider other){
        other.transform.SetParent(entity.transform, true);
    }
}
