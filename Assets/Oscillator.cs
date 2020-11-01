using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This component will move the object in oscillator way
*/
public class Oscillator : MonoBehaviour
{
    [SerializeField]
    float acceleration = -10;

    [SerializeField]
    float speed;

    [SerializeField]
    float scale = 10;

    [SerializeField]
    float x;

    void Start()
    {
        transform.position += new Vector3(scale, 0, 0);
        if (acceleration > 0) acceleration *= -1;
        speed = 0;
        x = scale;
    }

    void Update()
    {
        speed += acceleration * Time.deltaTime;
        if (transform.position.x <= 0.1 && transform.position.x > 0)
        {
            if (
                (acceleration < 0 && speed < 0) ||
                (acceleration > 0 && speed > 0)
            ) acceleration *= -1;
        }

        x += speed * Time.deltaTime;
        float y = -1 * scale * Mathf.Cos(1.5f / scale * x);
        transform.position = new Vector3(x, y, 0);
    }
}
