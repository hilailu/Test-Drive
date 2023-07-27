using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset;
    private bool isFirstPerson = false;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F5))
        {
            isFirstPerson = !isFirstPerson;
        }
    }
    
    void LateUpdate()
    {
        offset = isFirstPerson ? new Vector3(0, 2.5f, 0.5f) : new Vector3(0, 5, -7);
        transform.position = player.transform.position + offset;
    }
}
