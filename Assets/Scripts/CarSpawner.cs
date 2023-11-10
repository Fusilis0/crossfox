using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public Transform CarPos;
    public GameObject car;

    public float delay = 3;
    float timer;

    void SpawnCar()
    {
        Instantiate(car, CarPos.position, CarPos.rotation);
    }

    void Start()
    {
       
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            SpawnCar();
            timer = 0;
            
        }
    }
}
