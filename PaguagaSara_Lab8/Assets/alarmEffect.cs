using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarmEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            print("entre al trigger");
            GetComponent<Light>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            print("salí del trigger");
            GetComponent<Light>().enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("estoy en el trigger");
            GetComponent<Light>().intensity = Mathf.Sin(Time.time);
            
        }
    }
}
