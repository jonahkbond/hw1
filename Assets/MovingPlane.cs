﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlane : MonoBehaviour {

    public Transform movingPlatform;
    public Transform position1;
    public Transform position2;
    public Vector3 newPosition;
    public string currentState;
    public float smooth;
    public float resetTime;

    void Start()
    {
        changeTarget();
    }

    void FixedUpdate()
    {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);    
    }

    void changeTarget()
    {
        if(currentState == "Moving to Position 1")
        {
            currentState = "Moving to Position 2";
            newPosition = position2.position;
        }
        else if (currentState == "Moving to Position 2")
        {
            currentState = "Moving to Position 1";
            newPosition = position1.position;
        }
        else if (currentState == "")
        {
            currentState = "Moving to Position 2";
            newPosition = position2.position;
        }
        Invoke("changeTarget", resetTime);
    }
}
