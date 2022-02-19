using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetRaydaOlusma : MonoBehaviour
{
    public GameObject magnet;
    bool olusma = true;


    void Start()
    {
        GameObject cevreBir = Instantiate(magnet, transform.position, Quaternion.identity);
    }

    void Update()
    {
        /*int randomIlk = Random.Range(0, 2);
        if (randomIlk != 1)
        {
            olusma = false;
        }
        if (randomIlk == 1 && olusma)
        {
            GameObject cevreBir = Instantiate(magnet, transform.position, Quaternion.identity);
            olusma = false;
        }*/
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(magnet);
        }
    }
}
