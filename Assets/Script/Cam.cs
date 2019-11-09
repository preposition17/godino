using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Vector3 position;
    void Start()
    {
        // Assign zero value to position
        position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // Freeze camera, cause it shouldn't jump togetger with dino
        // transform.position = Vector3.Lerp(transform.position, position, 1f*Time.deltaTime);
    }
}
