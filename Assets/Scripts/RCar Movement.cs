using UnityEngine;

public class RCarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float carSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Move()
    {
        rb.velocity += transform.forward * carSpeed * Time.deltaTime;
    }

    void Update()
    {
        Move();
    }
}
