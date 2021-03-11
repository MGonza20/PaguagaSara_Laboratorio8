using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsSwitch : MonoBehaviour
{

    AudioSource flashlightSFX;

    // Start is called before the first frame update
    void Start()
    {
        flashlightSFX = GetComponent<AudioSource>();
        GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            flashlightSFX.Play();
        }
    }
}
