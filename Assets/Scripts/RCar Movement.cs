using UnityEngine;

public class RCarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float carSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(-carSpeed, 0, 0);
    }
}
