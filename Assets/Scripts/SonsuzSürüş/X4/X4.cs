using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class X4 : MonoBehaviour
{
    public Slider x4Slider;
    public float clock = 0f;

    public GameObject x4Canvas;

    bool x4Alındı_mı = false;

    void Start()
    {
        clock = 0f;
        x4Canvas.SetActive(false);
        PlayerPrefs.SetString("x4", "false");
    }


    void Update()
    {
        if (x4Alındı_mı)
        {
            clock = clock + Time.deltaTime;
            x4Slider.value = clock;
        }
    }

    public void X4Durdurucu()
    {
        x4Alındı_mı = false;
        x4Canvas.SetActive(false);
        PlayerPrefs.SetString("x4", "false");
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "x4")
        {
            x4Alındı_mı = true;
            CancelInvoke("X4Durdurucu");
            clock = 0f;
            PlayerPrefs.SetString("x4", "true");

            if (PlayerPrefs.GetFloat("x4upgrade") == 1f)
            {
                Invoke("X4Durdurucu", 10f);
                x4Canvas.SetActive(true);
                x4Slider.maxValue = 10f;
            }
            else if (PlayerPrefs.GetFloat("x4upgrade") == 2f)
            {
                Invoke("X4Durdurucu", 15f);
                x4Canvas.SetActive(true);
                x4Slider.maxValue = 15f;
            }
            else if (PlayerPrefs.GetFloat("x4upgrade") == 3f)
            {
                Invoke("X4Durdurucu", 20f);
                x4Canvas.SetActive(true);
                x4Slider.maxValue = 20f;
            }
            else if (PlayerPrefs.GetFloat("x4upgrade") == 4f)
            {
                Invoke("X4Durdurucu", 25f);
                x4Canvas.SetActive(true);
                x4Slider.maxValue = 25f;
            }
            else if (PlayerPrefs.GetFloat("x4upgrade") == 5f)
            {
                Invoke("X4Durdurucu", 30f);
                x4Canvas.SetActive(true);
                x4Slider.maxValue = 30f;
            }
            else
            {
                Invoke("X4Durdurucu", 10f);
                x4Canvas.SetActive(true);
                x4Slider.maxValue = 10f;
            }
        }
    }
}
