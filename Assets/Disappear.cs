﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This component will appear and Disappear the object everytime you'll click on the mouse!
*/
public class Disappear : MonoBehaviour
{

    float startX;
    float startY;
    float scaleX;
    float scaleY;
    
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
    }

    void Update()
    {
        // this function will work by mouse
        
          if(Input.GetMouseButtonDown(0)){
              if(transform.localScale.x == 0){
                   Vector3 show = new Vector3(startX,startY,0);
                   // Input.mousePosition ;
                    transform.localScale = new Vector3(scaleX,scaleY,0);   
                    transform.position = show ;  
                           // Debug.Log("clicked just" + Input.mousePosition );
                            return;

              }
         Vector3 disappear = new Vector3(0,0,0);
         transform.localScale = disappear;   
        // Debug.Log("clicked disapper");
             }  

         //By Up Arrow

        //           if(Input.GetKeyDown(KeyCode.UpArrow )){
        //       if(transform.localScale.x == 0){
        //            Vector3 show = new Vector3(1,1,0);
        //            // Input.mousePosition ;
        //             transform.localScale = new Vector3(1,1,0);   
        //             transform.position = show ;  
        //                     Debug.Log("clicked just" + Input.mousePosition );
        //                     return;

        //       }
        //  Vector3 disappear = new Vector3(0,0,0);
        //  transform.localScale = disappear;   
        //  Debug.Log("clicked disapper");
        //      }  

    }
}