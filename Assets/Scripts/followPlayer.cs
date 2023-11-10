using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float yPosition = 8.62f;

    void Update()
    {
        Vector3 setPosition = transform.position;
        setPosition.x = player.transform.position.x + offset.x;
        setPosition.z = player.transform.position.z + offset.z;
        transform.position = setPosition;
    }
}
