﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem part;

    // Start is called before the first frame update
    void Start()
    {
        part.Play();
    }

    // Update is called once per frame
   
}
