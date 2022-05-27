using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagswithbread : MonoBehaviour
    
{
    public Transform bread;
    public Vector3 _startposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionExit(Collision collision)
    {
        bread.transform.position = _startposition;
    }
}
