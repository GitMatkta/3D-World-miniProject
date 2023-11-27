using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 customGravity = new Vector3(0, -9.81f, 0); // Default gravity, can be adjusted in the Inspector
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true; // Ensure that gravity is enabled for the Rigidbody
        Physics.gravity = customGravity;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Apply force to the Rigidbody for movement
        rb.AddForce(movement * speed);
    }
}