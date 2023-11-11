using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public Transform CarPos;
    public GameObject car;
    public GameObject cloneCar;

    public float delay;
    public float destroyDelay = 5;
    float timer;

    void SpawnCar()
    {
       cloneCar = Instantiate(car, CarPos.position, CarPos.rotation);
    }

    void Start()
    {
       // SpawnCar();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > (10000 * Random.value))
        {
            SpawnCar();
            timer = 0;
        }

        Destroy(cloneCar, 5);
    }
}
