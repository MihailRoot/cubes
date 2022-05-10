using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody body;
    public float speed;
    public float rotationSpeed;
    private float vertical, horizontal;
    public bool is_groud = true;
    public float jump = 20;

    public float gravityforce = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = 30f;
        rotationSpeed = 50f;
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        //body.velocity = (transform.forward * vertical) * speed * Time.fixedDeltaTime;
        body.velocity = (-transform.up * vertical) * speed * Time.fixedDeltaTime;
        transform.Rotate((transform.forward * horizontal) * rotationSpeed * Time.fixedDeltaTime);
        // transform.Rotate((transform.up * horizontal) * rotationSpeed * Time.fixedDeltaTim
        body.AddForce(Physics.gravity * (gravityforce - 1) *body.mass);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && is_groud)
        {
            body.AddForce(Vector3.up * jump,ForceMode.Impulse);
        }
    }
}
