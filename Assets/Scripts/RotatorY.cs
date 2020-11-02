using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This component will make the object rotate according to the y scale
 */
public class RotatorY : MonoBehaviour
{
    [Tooltip("Rotation speed")]
    [SerializeField]
    float speed;

    void Start()
    {
        // Default value
        speed = 2f;
    }

    void Update()
    {
        // Rotate the object with given speed according to y axis
        transform.Rotate(0, speed, 0);
    }
}
