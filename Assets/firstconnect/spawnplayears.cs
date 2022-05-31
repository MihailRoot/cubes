using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class spawnplayears : MonoBehaviour
{
    public GameObject player;
    public float minX, minY, maxX, maxY, mixZ;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 random = new Vector2(Random.Range(minX, minY), Random.Range(maxX, maxY));
        Vector3 random = new Vector3(minX,minY,mixZ);

        PhotonNetwork.Instantiate(player.name,random,Quaternion.identity);
        
    }
}
