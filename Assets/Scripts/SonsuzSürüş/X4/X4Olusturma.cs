using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X4Olusturma : MonoBehaviour
{
    public GameObject myself;
    float speed = 3;

    void Update()
    {
        myself.transform.Rotate(new Vector3(0f, -15f, 0f) * Time.deltaTime * speed);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(myself);
        }
    }
}
