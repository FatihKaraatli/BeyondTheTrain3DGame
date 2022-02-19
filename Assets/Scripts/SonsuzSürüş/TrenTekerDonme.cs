using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrenTekerDonme : MonoBehaviour
{
    float speed = 15;

    
    void Update()
    {
        transform.Rotate(new Vector3(0f , -30f, 0f) * Time.deltaTime * speed);
    }
}
