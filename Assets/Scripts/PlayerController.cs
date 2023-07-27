using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isFirstPlayer;
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        horizontalInput = isFirstPlayer ? Input.GetAxis("Horizontal") : Input.GetAxis("HorizontalAlt");
        verticalInput = isFirstPlayer ? Input.GetAxis("Vertical") : Input.GetAxis("VerticalAlt");
        
        // Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotates the car
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
