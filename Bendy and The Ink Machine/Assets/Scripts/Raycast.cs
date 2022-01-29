using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Raycast : MonoBehaviour
{
    private GameObject raycastedObj;
    public GameObject modelDisc;
    public GameObject triggerDisc;
    public GameObject modelCan0;
    public GameObject modelCan1;
    public GameObject triggerCan1;
    public AudioSource discSound;
    public AudioSource soupSound;

    [SerializeField] private int rayLength = 10;
    [SerializeField] private LayerMask layerMaskInteract;

    [SerializeField] private Image uiCrosshair;

    private void Awake()
    {
        AudioSource audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        //Debug.Log("vector");

        if(Physics.Raycast(transform.position, fwd, out hit))
        {
            //Debug.Log("raycast?");
            if (hit.collider.CompareTag("disctrigga"))
            {
                raycastedObj = hit.collider.gameObject;
                //Debug.Log("object");

                if (Input.GetKeyDown("f"))
                {
                    //Debug.Log("interact with object");
                    //raycastedObj.SetActive(false);
                    modelDisc.SetActive(false);
                    triggerDisc.SetActive(false);
                    discSound.Play();

                }
            }
            if (hit.collider.CompareTag("cantrigga1"))
            {
                raycastedObj = hit.collider.gameObject;
                //Debug.Log("object");

                if (Input.GetKeyDown("f"))
                {
                    //Debug.Log("interact with object");
                    //raycastedObj.SetActive(false);
                    modelCan0.SetActive(false);
                    modelCan1.SetActive(false);
                    triggerCan1.SetActive(false);
                    soupSound.Play(); 

                }
            }
            else
            {
                //Debug.Log(hit.collider.gameObject.name);
            }
        }
        else
        {
            CrosshairNormal();
        }
    }

    void CrosshairActive()
    {
        uiCrosshair.color = Color.red;
    }

    void CrosshairNormal()
    {
        uiCrosshair.color = Color.white;
    }
}
