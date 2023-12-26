using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCarSpawner : MonoBehaviour
{
    public Transform CarPos;
    public GameObject car4;
    public GameObject car5;
    public GameObject car6;
    public GameObject cloneCar;
    public float CarLifetime;

    void SpawnCarR()
    {
        float carNumber = Random.Range(1, 4);
        if (carNumber == 1)
            cloneCar = Instantiate(car4, CarPos.position, CarPos.rotation);
        if (carNumber == 2)
            cloneCar = Instantiate(car5, CarPos.position, CarPos.rotation);
        if (carNumber == 3)
            cloneCar = Instantiate(car6, CarPos.position, CarPos.rotation);
    }

    void Start()
    {
        InvokeRepeating(nameof(SpawnCarR), Random.Range(0, 3), Random.Range(2, 8));
    }

    void CarDestroyer()
    {
        Destroy(cloneCar, CarLifetime);
    }

    void Update()
    {
        CarDestroyer();
    }
}
