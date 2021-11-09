using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    public float transitionSpeed;
    public Vector3 newPos;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(platformFall(1.0f));
        }
    }

    public IEnumerator platformFall (float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * transitionSpeed);
    }
}
