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

	[SerializeField] float a = -10;
	[SerializeField] float s = 10;
	[SerializeField] float scale = 10;
	float x;

    void Start()
    {
        t = 0;
        transform.position += new Vector3(scale,0,0);
        if (a > 0) a *= -1;
        s = 0;
        x = scale;
    }
 
    void Update()
    {
    	t+=Time.deltaTime;

    	s += a*Time.deltaTime;
    	if(transform.position.x <= 0.1 && transform.position.x > 0)
    	{
    		if( (a < 0 && s < 0) ||  (a > 0 && s > 0))
    		a *= -1;
    	}
    	
    	x += s*Time.deltaTime;
    	float y = -1*scale * Mathf.Cos(1.5f/scale * x);
    	transform.position = new Vector3(x,y,0);
    }

}