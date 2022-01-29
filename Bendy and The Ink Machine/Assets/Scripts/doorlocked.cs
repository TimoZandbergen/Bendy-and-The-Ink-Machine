using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlocked : MonoBehaviour
{

    public AudioSource doorSound;
    private bool atdoor;

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(atdoor == true)
        {
            if (Input.GetKeyDown("e"))
            {
                doorSound.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        atdoor = true;   
    }

    private void OnTriggerExit(Collider other)
    {
        atdoor = false;
    }
}
