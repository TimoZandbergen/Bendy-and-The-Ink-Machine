using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public GameObject SourceLight;
    private bool OnOff;


    private void Start()
    {
        OnOff = true;
        SourceLight.SetActive(true);
    }

    private void Update()
    {
        SourceLight.SetActive(OnOff);
        StartCoroutine(Delayy());
        //Debug.Log("hello");
    }

    IEnumerator Delayy()
    {
        //Debug.Log("start");
        yield return new WaitForSecondsRealtime(Random.Range(1f, 100f));
        OnOff = !OnOff;
        //Debug.Log("done");
    }
}
