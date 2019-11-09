using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Vector3 dir;
    void Start()
    {
        dir = Vector3.zero;
        dir.x = 0.5f*Mathf.Cos(transform.eulerAngles.y);
        dir.z = (0.5f*(Mathf.Sin(90 - transform.eulerAngles.y))/Mathf.Sin(transform.eulerAngles.x));
        dir.y = (0.5f*(Mathf.Sin(90 - transform.eulerAngles.y))/Mathf.Cos(transform.eulerAngles.y));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir*Time.deltaTime);
    }
}
