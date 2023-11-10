using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject floor;

    public Transform floorCheck;
    public float floorDistance = -5f;
    public LayerMask floorMask;
    bool isFloorExist;

    void CreateFloor()
    {
        Instantiate(floor, SpawnPos.position, SpawnPos.rotation);
    }

    void Start()
    {

    }

    void Update()
    {
        isFloorExist = Physics.CheckSphere(floorCheck.position, floorDistance, floorMask);
        if (!isFloorExist) {
            CreateFloor();
        }
        
    }
}
