using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public Transform CarPos;
    public GameObject car;
    public GameObject car2;
    public GameObject car3;
    public GameObject cloneCar;

    public float destroyDelay = 5;
    float timer;
    
    void SpawnCar()
    {
        float carNumber = Random.value;
        if ( carNumber < 0.33f )
            cloneCar = Instantiate(car, CarPos.position, CarPos.rotation);
       if (carNumber > 0.33f && carNumber < 0.66f)
            cloneCar = Instantiate(car2, CarPos.position, CarPos.rotation);
       if (carNumber > 0.66f)
            cloneCar = Instantiate(car3, CarPos.position, CarPos.rotation);
    }

    void Start()
    {

    }

    void Update()
    {
        float delay = 50000 * Random.value;
        timer += Time.deltaTime;

          if (timer > delay && delay > 1.2f)
          {
              SpawnCar();
              timer = 0;
          }

        Destroy(cloneCar, 5);
        
    }
}
