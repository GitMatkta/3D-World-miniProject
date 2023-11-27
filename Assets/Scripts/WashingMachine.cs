using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingMachine : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the rotation speed as needed

    void Update()
    {
        // Rotate the object around its local Z-axis
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
