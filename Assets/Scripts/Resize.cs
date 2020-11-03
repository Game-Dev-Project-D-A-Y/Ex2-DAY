using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This component resizes the object in continuous way (similiar to a heartbeat).
*/
public class Resize : MonoBehaviour
{

    [Tooltip("Limits the size of growth")]
    [SerializeField]
    float resize;

    [Tooltip("Speed of resizing")]
    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        // Default values: 
        resize = 1.3f;
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // The Sinus function makes the object grow in a harmonic way
        float scale = Mathf.Abs(Mathf.Sin(Time.time * speed) + resize);

        // Scales the object in x axis and y axis equally
        transform.localScale = new Vector3(scale, scale, 0);
    }
}
