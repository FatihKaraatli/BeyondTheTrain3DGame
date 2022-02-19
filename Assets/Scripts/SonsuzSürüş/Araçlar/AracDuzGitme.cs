using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AracDuzGitme : MonoBehaviour
{
    float sayi = -5;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0f, 0f, sayi *Time.deltaTime * 5f);
        
    }
}
