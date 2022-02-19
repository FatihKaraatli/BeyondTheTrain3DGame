using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraPosition : MonoBehaviour
{
    public float lerpNumber = 3f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (PlayerPrefs.GetString("kamera") == "lokomotif")
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-0.247f, 0, 1.318f), Time.deltaTime * lerpNumber);
        }
        else if (PlayerPrefs.GetString("kamera") == "carriage")
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(1.206f, 0, 3.147f), Time.deltaTime * lerpNumber);
        }
    }
}
