using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//////        
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision other)
    {
        Application.Quit();
    }
}
