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
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = 100f;
        rotationSpeed = 50f;
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        //body.velocity = (transform.forward * vertical) * speed * Time.fixedDeltaTime;
        body.velocity = (-transform.up * vertical) * speed * Time.fixedDeltaTime;
        transform.Rotate((transform.forward * horizontal) * rotationSpeed * Time.fixedDeltaTime);
        // transform.Rotate((transform.up * horizontal) * rotationSpeed * Time.fixedDeltaTime);
        if (Input.GetKey(("escape")))
        {
            Application.Quit();
        }
    }
}
