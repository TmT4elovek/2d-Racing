using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public float speed = 5f;
    public float rotationSpeed = 200f;

    private Rigidbody2D rb;


    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }



    void Update()
    {
        
        float rotation = -Input.GetAxis("Horizontal") * rotationSpeed;
        float acceleration = Input.GetAxis("Vertical") * speed;

        rb.angularVelocity = rotation;
        rb.velocity = transform.up * acceleration;

    }
}
