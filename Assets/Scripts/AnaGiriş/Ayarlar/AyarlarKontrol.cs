using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AyarlarKontrol : MonoBehaviour
{
    public GameObject anaGiris;
    public GameObject settings;


    public void Back()
    {
        anaGiris.SetActive(true);
        settings.SetActive(false);
    }


}
