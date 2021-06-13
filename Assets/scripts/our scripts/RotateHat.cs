using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHat : MonoBehaviour
{
    public GameObject hat; 
    private int rotationSpeed = 20;
    public int direction;

    // Update is called once per frame
    void Update()
    {
        hat.transform.Rotate(Vector3.up*(direction*rotationSpeed*Time.deltaTime));
    }
}
