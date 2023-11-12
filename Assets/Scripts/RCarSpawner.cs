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

    public float destroyDelay = 5;
    float timer;

    void SpawnCarR()
    {
        float carNumber = Random.value;
        if (carNumber < 0.33f)
            cloneCar = Instantiate(car4, CarPos.position, CarPos.rotation);
        if (carNumber > 0.33f && carNumber < 0.66f)
            cloneCar = Instantiate(car5, CarPos.position, CarPos.rotation);
        if (carNumber > 0.66f)
            cloneCar = Instantiate(car6, CarPos.position, CarPos.rotation);
    }

    void Start()
    {
        
    }

    void Update()
    {
        float delay = 1000 * Random.value;
        timer += Time.deltaTime;

        if (timer > delay && delay > 1.2f)
        {
            SpawnCarR();
            timer = 0;
        }

        Destroy(cloneCar, 5);
    }
}
