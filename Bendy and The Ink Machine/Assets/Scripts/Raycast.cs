using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    private GameObject raycastedObj;

    [SerializeField] private int rayLength = 10;
    [SerializeField] private LayerMask layerMaskInteract;

    [SerializeField] private Image uiCrosshair;

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        //Debug.Log("vector");

        if(Physics.Raycast(transform.position, fwd, out hit))
        {
            //Debug.Log("raycast?");
            if (hit.collider.CompareTag("Object"))
            {
                raycastedObj = hit.collider.gameObject;
                //Debug.Log("object");

                if (Input.GetKeyDown("f"))
                {
                    //Debug.Log("interact with object");
                    raycastedObj.SetActive(false);
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
