using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorSound : MonoBehaviour
{

    public AudioSource lockedDoor;
    // Start is called before the first frame update
    private void Awake()
    {
        AudioSource audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
