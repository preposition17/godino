using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class Dino : MonoBehaviour
{
    private float z_coordinate = 0;
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
        DinoJump();
        // Aligns dino on the center of the road
        // AlignDino();
        // Sometimes dino fails underground, i hope it helps, but not sure
        if(transform.position.y < 0.49f){
            transform.position = new Vector3(transform.position.x, 0.5f, z_coordinate);
        }
        Debug.Log(transform.position.z);
    }
    private void DinoMoveForward(){
        transform.Translate(direction*Time.deltaTime);
        // When Dino is landing, we accelerate landing
        if(rb.velocity.y < 0){
            rb.AddForce(Vector3.down * 50 * rb.mass);
        }
    }
    private void DinoJump(){
        // If dino grounded and space button is down, then dino jumps
        if(Input.GetMouseButtonDown(0)){    
            if(Input.mousePosition.x > 230.0f && Input.mousePosition.x < 490.0f && transform.position.y <= 0.5){
                // Jump
                rb.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
            }
            else if(Input.mousePosition.x <= 230.0f && transform.position.y <= 0.5){
                // Jump to the left
                rb.AddForce(new Vector3(0,5,1f), ForceMode.Impulse);
                z_coordinate+=1.5f;
            }
            else if(Input.mousePosition.x >= 490.0f && transform.position.y <= 0.5){
                // Jump to the right
                rb.AddForce(new Vector3(0,5,-1f), ForceMode.Impulse);
                z_coordinate-=1.5f;
            }
        }
    }
    private void AlignDino(){
        float eps = 0.001f;
        if(transform.position.y < 0.5){
            if(Mathf.Abs(transform.position.z - z_coordinate) >= eps){
                direction.z = -(transform.position.z - z_coordinate);
            }
        }
    }
}
