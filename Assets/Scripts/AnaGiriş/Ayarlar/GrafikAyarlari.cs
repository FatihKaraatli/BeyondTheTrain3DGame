using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrafikAyarlari : MonoBehaviour
{
    public Camera kamera;

    public GameObject lowToggle;
    public GameObject mediumToggle;
    public GameObject highToggle;
    public GameObject ultraToggle;
    void Start()
    {
        if (PlayerPrefs.GetString("kamerafar") == null)
        {
            kamera.farClipPlane = 50f;
        }
        else if (PlayerPrefs.GetString("kamerafar") == "low")
        {
            kamera.farClipPlane = 50f;
        }
        else if (PlayerPrefs.GetString("kamerafar") == "medium")
        {
            kamera.farClipPlane = 100f;
        }
        else if (PlayerPrefs.GetString("kamerafar") == "high")
        {
            kamera.farClipPlane = 150f;
        }
        else if (PlayerPrefs.GetString("kamerafar") == "ultra")
        {
            kamera.farClipPlane = 200f;
        }
    }

    public void Update()
    {
        ToggleChoose();
    }

    public void Low()
    {
        PlayerPrefs.SetString("kamerafar", "low");
        kamera.farClipPlane = 50f;
    }
    public void Medium()
    {
        PlayerPrefs.SetString("kamerafar", "medium");
        kamera.farClipPlane = 100f;
    }
    public void High()
    {
        PlayerPrefs.SetString("kamerafar", "high");
        kamera.farClipPlane = 150f;
    }
    public void Ultra()
    {
        PlayerPrefs.SetString("kamerafar", "ultra");
        kamera.farClipPlane = 200f;
    }

    public void ToggleChoose()
    {
        if (PlayerPrefs.GetString("kamerafar") == null)
        {
            lowToggle.SetActive(false);
            mediumToggle.SetActive(false);
            highToggle.SetActive(false);
            ultraToggle.SetActive(true);
        }
        else if (PlayerPrefs.GetString("kamerafar") == "low")
        {
            lowToggle.SetActive(true);
            mediumToggle.SetActive(false);
            highToggle.SetActive(false);
            ultraToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("kamerafar") == "medium")
        {
            lowToggle.SetActive(false);
            mediumToggle.SetActive(true);
            highToggle.SetActive(false);
            ultraToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("kamerafar") == "high")
        {
            lowToggle.SetActive(false);
            mediumToggle.SetActive(false);
            highToggle.SetActive(true);
            ultraToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("kamerafar") == "ultra")
        {
            lowToggle.SetActive(false);
            mediumToggle.SetActive(false);
            highToggle.SetActive(false);
            ultraToggle.SetActive(true);
        }
        else
        {
            lowToggle.SetActive(false);
            mediumToggle.SetActive(false);
            highToggle.SetActive(false);
            ultraToggle.SetActive(true);
        }
    }
}
