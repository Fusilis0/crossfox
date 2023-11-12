using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float carSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(carSpeed, 0, 0);
    }
}
