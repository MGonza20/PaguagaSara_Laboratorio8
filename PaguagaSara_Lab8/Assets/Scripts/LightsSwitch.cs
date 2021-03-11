using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsSwitch : MonoBehaviour
{

    //AudioSource flashlightSFX;

    // Start is called before the first frame update
    void Start()
    {
        //flashlightSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        GetComponent<AudioSource>().Play();

    }
}
