using UnityEngine;

public class BoardController : MonoBehaviour
{
    public float tiltSpeed = 5f;

    void Update()
    {
        // Get input from WASD or arrow keys
        float tiltX = Input.GetAxis("Vertical") * tiltSpeed * Time.deltaTime;
        float tiltZ = -Input.GetAxis("Horizontal") * tiltSpeed * Time.deltaTime;

        // Apply rotation to the board
        transform.Rotate(tiltX, 0, tiltZ);
    }
}
