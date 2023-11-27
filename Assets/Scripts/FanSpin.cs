using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        // Rotate the object around its own axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}