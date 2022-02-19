using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovment : MonoBehaviour
{
    public GameObject tren;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && tren.transform.position.x < 1 )
        {
            transform.position += new Vector3(-2f, 0, 0);  
        }

        if (Input.GetKeyDown(KeyCode.A) && tren.transform.position.x > -1)
        {
            transform.position += new Vector3(2f, 0, 0);
        }
    }
}
