using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/**
* This component will move the object in oscillator way
*/
public class Oscillator : MonoBehaviour
{
float t;
float g = 10f;
float v0 = 0f;
float h0 = 10f;
float v = 0;
    void Start()
    {
        t = 0;
        transform.position = new Vector3(0,0,0);
    }
 
    void Update()
    {
    	t += Time.deltaTime;
    	float delta_h = Math.Abs(transform.position.x - h0);
    	v += Mathf.Sqrt(2 * g * delta_h);
    	Debug.Log("v: "+ v+"\nt: "+t);
    	Debug.Log("v*t: "+v * t);

    	transform.position += new Vector3(v*t,0,0);
    }

}