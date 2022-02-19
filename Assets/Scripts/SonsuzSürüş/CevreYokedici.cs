using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CevreYokedici : MonoBehaviour
{
    public GameObject cevre;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(cevre, 1f);
        }
    }
}
