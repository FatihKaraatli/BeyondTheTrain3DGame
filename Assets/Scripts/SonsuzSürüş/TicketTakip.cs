using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TicketTakip : MonoBehaviour
{
    GameObject tren;
    public float lerpNumber = 1;

    float mesafeX;
    float mesafeZ;
    float mesafeKareX;
    float mesafeKareZ;

    float mesafe;

    public void Start()
    {
        tren = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (PlayerPrefs.GetString("magnet") == "true")
        {
            mesafeX = tren.transform.position.x - transform.position.x;
            mesafeX = Mathf.Abs(mesafeX);
            mesafeKareX = mesafeX * mesafeX;

            mesafeZ = tren.transform.position.z - transform.position.z;
            mesafeZ = Mathf.Abs(mesafeZ);
            mesafeKareZ = mesafeZ * mesafeZ;

            mesafe = mesafeKareZ + mesafeKareX;

            mesafe = Mathf.Sqrt(mesafe);

            if (mesafe < 5)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(tren.transform.position.x, tren.transform.position.y, tren.transform.position.z), Time.deltaTime * lerpNumber);
            }
        }
    }
}
