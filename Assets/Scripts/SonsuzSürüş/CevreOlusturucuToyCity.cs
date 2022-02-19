using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CevreOlusturucuToyCity : MonoBehaviour
{
    public GameObject[] yerler;
    public float mesafe = 0f;
    bool olustur = true;
    bool ilkSekiz = true;

    public GameObject tren;
    void Update()
    {
        if (ilkSekiz)
        {
            for (int i = 0; i < 1; i++)
            {
                int randomIlk = Random.Range(0, 2);
                GameObject cevreBir = Instantiate(yerler[randomIlk], new Vector3(0, 0, -139.8f + mesafe), Quaternion.Euler(0, 90f, 0));
                mesafe += 99f;
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
        int randomIki = Random.Range(0, 2);
        GameObject cevreIki = Instantiate(yerler[randomIki], new Vector3(0, 0, -139.8f + mesafe), Quaternion.Euler(0, 90f, 0));
        mesafe += 99f;
        olustur = false;
        yield return new WaitForSeconds(0.1f);
        olustur = true;
    }
}
