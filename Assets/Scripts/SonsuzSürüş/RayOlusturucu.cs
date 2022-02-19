using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayOlusturucu : MonoBehaviour
{
    public GameObject[] yerler;
    public GameObject[] ilkDort;
    public float mesafe = 0f;
    bool olustur = true;
    bool ilkSekiz = true;

    public GameObject tren;

    void Update()
    {
        if (ilkSekiz)
        {
            for (int i = 0; i < 4; i++)
            {
                int randomIlk = Random.Range(0, 180);
                GameObject cevreBir = Instantiate(ilkDort[i], new Vector3(0, 0, -139.8f + mesafe), Quaternion.Euler(0, 90f, 0));
                mesafe += 19.8f;
            }
            for (int i = 0; i < 5; i++)
            {
                int randomIlk = Random.Range(0, 180);
                GameObject cevreBir = Instantiate(yerler[randomIlk], new Vector3(0, 0, -139.8f + mesafe), Quaternion.Euler(0, 90f, 0));
                mesafe += 19.8f;
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
        int randomIki = Random.Range(0, 180);
        GameObject cevreIki = Instantiate(yerler[randomIki], new Vector3(0, 0, -139.8f + mesafe), Quaternion.Euler(0, 90f, 0));
        mesafe += 19.8f;
        olustur = false;
        yield return new WaitForSeconds(0.5f);
        olustur = true;
    }
}
