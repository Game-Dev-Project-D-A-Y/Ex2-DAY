using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* This component will show and Disappear the object everytime you'll click the mouse left button
*/
public class Disappear : MonoBehaviour
{

    float startX;
    float startY;
    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // By mouse

          if(Input.GetMouseButtonDown(0)){
              if(transform.localScale.x == 0){
                   Vector3 show = new Vector3(startX,startY,0);
                   // Input.mousePosition ;
                    transform.localScale = new Vector3(1,1,0);   
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