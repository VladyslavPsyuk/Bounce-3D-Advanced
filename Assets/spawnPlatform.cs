using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlatform : MonoBehaviour
{
    public GameObject PlatformPrefub;
    public Vector3 platformPosition;
    void Start()
    {
        platformPosition = new Vector3 (11.325f, 4.182f, 10.0461f);
    }

 
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(PlatformPrefub, platformPosition, Quaternion.identity);
        }
    }
}
