using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayYokedici : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(transform.root.gameObject, 1f);
        }
    }

}
