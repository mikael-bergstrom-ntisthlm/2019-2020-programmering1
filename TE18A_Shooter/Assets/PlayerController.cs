﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 3;

    void Start()
    {
        
    }

    void Update()
    {

        float controlX = Input.GetAxisRaw("Horizontal");
        float controlY = Input.GetAxisRaw("Vertical");

        Vector3 movementX = Vector3.right * controlX * Time.deltaTime * speed;
        Vector3 movementY = Vector3.up * controlY * Time.deltaTime * speed;

        transform.Translate(movementX + movementY);
        

    }
}
