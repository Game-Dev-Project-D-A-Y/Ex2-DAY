using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This component will move the object in oscillator way
*/
public class Oscillator : MonoBehaviour
{   

    [Tooltip("Swing speed")]
    [SerializeField]
    float speed;

    [Tooltip("Swing distance from center")]
    [SerializeField]
    float scale;

    // Holds the starting x coordinate
    float startX;

    // Holds the starting y coordinate
    float startY;

    void Start()
    {
        // Default values:
        speed = 1;
        scale = 5;
        startX = transform.position.x;
        startY = transform.position.y;
    }

    void Update()
    {
        // The boundries of x is represented by the Sin function 
        float x = Mathf.Sin(Time.time * speed) * scale;
        
        // The boundries of y are limited according to the following function which we have created online
        float y = -1 * scale * Mathf.Cos(1.5f / scale * x);
        
        // Change object position
        transform.position = new Vector3(startX + x, startY+ y, 0);
    }
}
