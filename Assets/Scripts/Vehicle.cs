using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private float speed = 20f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
