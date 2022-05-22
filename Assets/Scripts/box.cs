using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject player;
    public Transform Spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        player.transform.position = Spawn.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
