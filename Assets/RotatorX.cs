using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This component will make the object rotate according to the x scale
 */
public class RotatorX : MonoBehaviour
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
        // Rotate the object with given speed according to x axis
        transform.Rotate(speed, 0, 0);
    }
}
