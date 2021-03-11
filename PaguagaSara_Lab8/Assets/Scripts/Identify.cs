using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Identify : MonoBehaviour
{
    public GameObject[] canvass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray CameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInf;


        if (Physics.Raycast(CameraRay, out hitInf, 5))
        {
            if (hitInf.collider.CompareTag("box"))
            {
                canvass[0].SetActive(false);
                canvass[1].SetActive(true);

            }
            else if (hitInf.collider.CompareTag("globe"))
            {
                canvass[0].SetActive(true);
                canvass[1].SetActive(false);
            }
            else
            {
                canvass[0].SetActive(false);
                canvass[1].SetActive(false);
            }
        }
        else
        {
            canvass[0].SetActive(false);
            canvass[1].SetActive(false);
        }
    }


}
