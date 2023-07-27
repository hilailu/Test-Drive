using UnityEngine;

public class Propeller : MonoBehaviour
{
    private float rotationSpeed = 300f; 
    
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
