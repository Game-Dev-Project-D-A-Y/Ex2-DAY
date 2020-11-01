using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * * This component will make the object rotate by the z scale in 2D
 */
public class Rotator : MonoBehaviour
{

    [Tooltip("Rotation speed")]
    [SerializeField]
    float speed;

    void Start()
    {
        // Default value
        speed = 1f;
    }

    void Update()
    {
        // Rotate the object with given speed according to z axis
        transform.Rotate(0, 0, speed);

        // **  Another way to rotate the object: **
        // **  transform.Rotate(Vector3.forward * speed * Time.deltaTime); **
    }
}
