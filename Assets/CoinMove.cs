using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    //adjust this to change speed
    [SerializeField]
    float speed = 5f;
    //adjust this to change how high it goes
    [SerializeField]
    float height = 0.1f;

    Vector3 pos;

    public float rotateSpeed = 10f;

    private void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
     
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
