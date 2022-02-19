using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CevreOlusturucuDesert : MonoBehaviour
{
    public GameObject yerler;
    public float mesafe = 0f;
    bool olustur = true;
    bool ilkSekiz = true;

    public GameObject tren;

    void Update()
    {
        if (ilkSekiz)
        {
            for (int i = 0; i < 2; i++)
            {
                GameObject cevreBir = Instantiate(yerler , new Vector3(0, 0, -139.8f + mesafe), Quaternion.Euler(0, 90f, 0));
                mesafe += 316.8f;
            }
            ilkSekiz = false;
        }
        if (olustur && Mathf.Abs(mesafe - tren.transform.position.z) < 380)
        {
            StartCoroutine(CevreDelay());
        }
    }

    IEnumerator CevreDelay()
    {
        GameObject cevreIki = Instantiate(yerler , new Vector3(0, 0, -139.8f + mesafe), Quaternion.Euler(0, 90f, 0));
        mesafe += 316.8f;
        olustur = false;
        yield return new WaitForSeconds(0.1f);
        olustur = true;
    }
}
