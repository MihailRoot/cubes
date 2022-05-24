using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waffles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 19 + Mathf.Sin(Time.fixedTime) * 1, transform.position.z );
    }
}
