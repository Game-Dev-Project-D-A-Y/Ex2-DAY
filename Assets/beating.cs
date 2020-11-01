using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class beating : MonoBehaviour
{
    
 
    // double size_one = 1.5 ;
    // double size_two = 0.2 ;
    // double tmp  ;
    // Start is called before the first frame update
    void Start()
    {
        // tmp = Math.Sin(size_one) ;
        //  transform.localScale = new Vector3((float)tmp,(float)tmp,0);
    }

    // Update is called once per frame
    void Update()   
    {
        //  tmp = Math.Sin(size_two);
        //  transform.localScale = new Vector3((float)tmp,(float)tmp,0);
        // tmp = Math.Sin(size_one) ;
        //  transform.localScale = new Vector3((float)tmp,(float)tmp,0);
Vector3 vec = new Vector3(Mathf.Abs(Mathf.Sin(Time.time)), Mathf.Abs(Mathf.Sin(Time.time)), 0);
 
         transform.localScale = vec;
         Debug.Log("time: "+Time.time);
    }
}
