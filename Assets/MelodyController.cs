using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelodyController : MonoBehaviour
{
    public AudioSource audioData;
    public bool turnOn = false;
    // Start is called before the first frame update
    public void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    public void PlayMusic ()
    {
        if(turnOn == true) 
        {
            audioData.Play(0);
            turnOn = false;
        }
        else
        { 
            audioData.Pause();
            turnOn = true;
           
        }
        Debug.Log(turnOn);
    }
}
