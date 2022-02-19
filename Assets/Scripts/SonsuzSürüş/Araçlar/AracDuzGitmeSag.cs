using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AracDuzGitmeSag : MonoBehaviour
{
    float sayi = 2f;
    void Start()
    {

    }

    void Update()
    {
        transform.position += new Vector3(0f, 0f, sayi * Time.deltaTime * 5f);

    }
}
