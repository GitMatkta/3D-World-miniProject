using UnityEngine;

public class GoalCam : MonoBehaviour
{
    public GameObject finishCamera; // Reference to the Finish Camera GameObject

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            // Activate the Finish Camera
            finishCamera.SetActive(true);

            // Deactivate the TextMeshPro component (if needed)
            // displayText.gameObject.SetActive(false);

            // Optionally, you can pause or perform other actions here

            // Deactivate the Goal GameObject to prevent further collisions
            gameObject.SetActive(false);
        }
    }
}