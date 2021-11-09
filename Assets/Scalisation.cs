using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalisation : MonoBehaviour
{

    public GameObject Sphere;
    public Vector3 scaleChange, positionChange;
    public bool changeScale = false;
    public int scaleState = 0;


    public void Start()
    {
        Sphere = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
    
        if (changeScale == true )
        Sphere.transform.localScale += scaleChange;
     
        if (Sphere.transform.localScale.y < 0.1f || Sphere.transform.localScale.y > 2f)
        {
            changeScale = false;
     
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" )
        {
            changeScale = true;
        }
    
    }
}
