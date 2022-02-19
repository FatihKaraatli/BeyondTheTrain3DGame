using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class X2 : MonoBehaviour
{
    public Slider x2Slider;
    public float clock = 0f;

    public GameObject x2Canvas;

    bool x2Alındı_mı = false;

    void Start()
    {
        clock = 0f;
        x2Canvas.SetActive(false);
        PlayerPrefs.SetString("x2", "false");
    }


    void Update()
    {
        if (x2Alındı_mı)
        {
            clock = clock + Time.deltaTime;
            x2Slider.value = clock;
        }
    }

    public void X2Durdurucu()
    {
        x2Alındı_mı = false;
        x2Canvas.SetActive(false);
        PlayerPrefs.SetString("x2", "false");
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "x2")
        {
            x2Alındı_mı = true;
            CancelInvoke("X2Durdurucu");
            clock = 0f;
            PlayerPrefs.SetString("x2", "true");

            if (PlayerPrefs.GetFloat("x2upgrade") == 1f)
            {
                Invoke("X2Durdurucu", 10f);
                x2Canvas.SetActive(true);
                x2Slider.maxValue = 10f;
            }
            else if (PlayerPrefs.GetFloat("x2upgrade") == 2f)
            {
                Invoke("X2Durdurucu", 15f);
                x2Canvas.SetActive(true);
                x2Slider.maxValue = 15f;
            }
            else if (PlayerPrefs.GetFloat("x2upgrade") == 3f)
            {
                Invoke("X2Durdurucu", 20f);
                x2Canvas.SetActive(true);
                x2Slider.maxValue = 20f;
            }
            else if (PlayerPrefs.GetFloat("x2upgrade") == 4f)
            {
                Invoke("X2Durdurucu", 25f);
                x2Canvas.SetActive(true);
                x2Slider.maxValue = 25f;
            }
            else if (PlayerPrefs.GetFloat("x2upgrade") == 5f)
            {
                Invoke("X2Durdurucu", 30f);
                x2Canvas.SetActive(true);
                x2Slider.maxValue = 30f;
            }
            else
            {
                Invoke("X2Durdurucu", 10f);
                x2Canvas.SetActive(true);
                x2Slider.maxValue = 10f;
            }
        }
    }
}
