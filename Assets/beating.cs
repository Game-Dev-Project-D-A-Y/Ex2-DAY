using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/**
* This component will cahnge the object size like a beating heart 
*/
public class beating : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()   
    {

Vector3 vec = new Vector3(Mathf.Abs(Mathf.Sin(Time.time)), Mathf.Abs(Mathf.Sin(Time.time)), 0);
 
         transform.localScale = vec;
        // Debug.Log("time: "+Time.time);
    }
}
