using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Vector3 dir;
    void Start()
    {
        dir = Vector3.zero;
        dir.x = 1.0f*Mathf.Cos(transform.eulerAngles.y*3.14159265359f/180)*Mathf.Sin(transform.eulerAngles.x*3.14159265359f/180);
        dir.y = 1.0f*Mathf.Sin(transform.eulerAngles.x*3.14159265359f/180)*Mathf.Sin(transform.eulerAngles.y*3.14159265359f/180);
        dir.z = 1.0f*Mathf.Cos(transform.eulerAngles.x*3.14159265359f/180);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir*Time.deltaTime);
        Debug.Log("x - " +dir.x.ToString());
        Debug.Log("y - " +dir.y.ToString());
        Debug.Log("z - " +dir.z.ToString());
        Debug.Log("cos of angle - " + Mathf.Cos(transform.eulerAngles.y*3.14159265359f/180).ToString());
    }
}
