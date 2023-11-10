using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float carSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(carSpeed, 0, 0);
    }
}
