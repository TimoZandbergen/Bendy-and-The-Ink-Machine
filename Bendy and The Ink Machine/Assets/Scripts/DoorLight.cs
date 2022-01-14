using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLight : MonoBehaviour
{
    public GameObject doorLight;
    public AudioSource doorSound;
    public GameObject self;

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        doorSound.Play();
        doorLight.SetActive(false);
        Destroy(self);
    }
}