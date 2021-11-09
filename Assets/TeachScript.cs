using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeachScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.Translate(0f, 0f, transform.position.z + 1f);
        }
        if (Input.GetKeyDown("s"))
        {
            transform.Translate(0f, 0f, transform.position.z - 1f);
        }
        if (Input.GetKeyDown("a"))
        {
            transform.Translate(transform.position.x + 1f, 0f, 0f);
        }
        if (Input.GetKeyDown("d"))
        {
            transform.Translate(transform.position.x - 1f, 0f, 0f);
        }
    }
}
