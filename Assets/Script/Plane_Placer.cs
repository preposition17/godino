using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Placer : MonoBehaviour
{
    public Transform Player;
    public Plane[] PlanePrefabs;
    public Plane FirstPlane;
    private List<Plane> spawnedPlanes = new List<Plane>();

    // Start is called before the first frame update
    void Start()
    {
        spawnedPlanes.Add(FirstPlane);
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.position.x > spawnedPlanes[spawnedPlanes.Count - 1].End.position.x - 6)
        {
            SpawnPlane();
        }
    }

    private void SpawnPlane()
    {
        Plane newPlane = Instantiate(PlanePrefabs[Random.Range(0, PlanePrefabs.Length)]);
        newPlane.transform.position = spawnedPlanes[spawnedPlanes.Count - 1].End.position - newPlane.Begin.localPosition;
        spawnedPlanes.Add(newPlane);
    }
}
