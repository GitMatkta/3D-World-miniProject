using UnityEngine;

public class BounceBackBumper : MonoBehaviour
{
    [SerializeField] private float bounceForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Rigidbody otherRB = collision.rigidbody;
            otherRB.AddExplosionForce(bounceForce, collision.contacts[0].point, 5);
           
        }
    }
}