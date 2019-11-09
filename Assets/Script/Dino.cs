using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    private float speed = 1f;
    public float jumpPower = 10.0f;
    private float gravityF;
    public Rigidbody rb;
    private Vector3 direction;
    private void Start(){
        rb = GetComponent<Rigidbody>();
        direction = Vector3.zero;
        direction.x = speed;
    }
    
    private void Update(){
        DinoMoveForward();
        DinoGravity();
    }

    private void DinoMoveForward(){
        transform.Translate(direction*Time.deltaTime);
    }

    public void DinoGravity(){
        if(Input.GetButtonDown("Jump") && transform.position.y <= 0.5){
            rb.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
        }
    }
}
