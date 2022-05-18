using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafirstlv : MonoBehaviour
{
    public Transform target;
    public Camera cam;
    private float mouseSen = 3.0f;
    public float distance = 10;
    private float rotationY;
    private float rotationX;
    private Vector3 previousPosition;
    
    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
        // offset = transform.position - target.transform.position;
        // Mousespeed = 10;
    }

    void LateUpdate()
    {
        // MouseX = Input.GetAxis("Mouse X") * Mousespeed * Time.deltaTime;
        // MouseY = -Input.GetAxis("Mouse Y") * Mousespeed * Time.deltaTime;
        // transform.rotation *= Quaternion.Euler(MouseX, MouseY, 0);
        // transform.position = target.transform.position + offset;
    }
    // Update is called once per frame
    void Update()
    {
        // transform.LookAt(target);
        // float mouseX = -Input.GetAxis("Mouse X") * mouseSen;
        // float mouseY = -Input.GetAxis("Mouse Y") * mouseSen;
        // rotationX += mouseX;
        // rotationY += mouseY;
        // transform.localEulerAngles = new Vector3(rotationX, rotationY, 0f);
         // transform.position = target.transform.position + new Vector3(0, 1, -5);
          // Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
          // pos.x = Mathf.Clamp01(pos.x);
          // pos.y = Mathf.Clamp01(pos.y);
          // transform.position = Camera.main.WorldToViewportPoint(pos);
          if (Input.GetMouseButtonDown(0))
          {
              previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
          }
          else if(Input.GetMouseButton(0))
          {
              Vector3 newposition = cam.ScreenToViewportPoint(Input.mousePosition);
              Vector3 direction = previousPosition - newposition;
              float rotationAroundYAxis = -direction.x * 180;
              float rotationAroundXAxis = direction.x * 180;
              cam.transform.position = target.position;
              cam.transform.Rotate(new Vector3(1,0,0),rotationAroundXAxis);
              cam.transform.Rotate(new Vector3(0,1,0), rotationAroundYAxis,Space.World);
              cam.transform.Translate(new Vector3(0,0,-distance));
              previousPosition = newposition;
          }
    }
}
