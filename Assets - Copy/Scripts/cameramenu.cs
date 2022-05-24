using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramenu : MonoBehaviour
{
    public GameObject camera;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        camera.GetComponent<Animation>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
