using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraDonme : MonoBehaviour
{
    public float speed = 0.01f;


    void Start()
    {
        
    }

    
    void Update()
    {

        this.transform.RotateAround(new Vector3(0f , 0f ,0f) , new Vector3(0f, 1f , 0f) , 30f * Time.deltaTime);
    }
}
