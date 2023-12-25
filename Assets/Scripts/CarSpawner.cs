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
    
    void SpawnCar()
    {
        float carNumber = Random.Range(1,4);
        if ( carNumber == 1 )
            cloneCar = Instantiate(car, CarPos.position, CarPos.rotation);
       if (carNumber == 2)
            cloneCar = Instantiate(car2, CarPos.position, CarPos.rotation);
       if (carNumber == 3)
            cloneCar = Instantiate(car3, CarPos.position, CarPos.rotation);
    }

    void Start()
    {
        InvokeRepeating(nameof(SpawnCar), Random.Range(0, 3), Random.Range(2,8));
    }

    void Update()
    {
        Destroy(cloneCar, 5);
    }
}
