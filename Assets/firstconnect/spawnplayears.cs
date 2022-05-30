using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class spawnplayears : MonoBehaviour
{
    public GameObject player;
    public float minX,minY, maxX, maxY;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 random = new Vector2(Random.Range(minX, minY), Random.Range(maxX, maxY));
        PhotonNetwork.Instantiate(player.name,random,Quaternion.identity);
        
    }
}
