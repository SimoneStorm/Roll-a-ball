using UnityEngine;

public class BallReset : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        // The starting position of the ball
        startPosition = new Vector3(-9f, 1f, 9f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathZone") || other.CompareTag("Hole"))
        {
            // Reset the ball to the start position
            transform.position = startPosition;
            GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
