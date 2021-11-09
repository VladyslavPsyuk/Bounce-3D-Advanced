using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public GameObject dooreToOpen;
    public Vector3 destination;
    public bool openTheDoor = false;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            openTheDoor = true;
        }
    }
    public void Update()
    {
        if (openTheDoor==true)
        {
            dooreToOpen.transform.position = Vector3.Lerp(dooreToOpen.transform.position, dooreToOpen.transform.position + destination, 0.15f * Time.deltaTime);
        }
        if (dooreToOpen.transform.position.y >6 )
        {
            openTheDoor = false;
        }
    }
}
