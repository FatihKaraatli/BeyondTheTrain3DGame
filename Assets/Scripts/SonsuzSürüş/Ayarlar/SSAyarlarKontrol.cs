using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSAyarlarKontrol : MonoBehaviour
{
    public AudioSource anaGirisSes;
    public GameObject sesAcık;
    public GameObject sesKapalı;

    public AudioSource soundEffectSes;
    public GameObject sesSoundEffectAcık;
    public GameObject sesSoundEffectKapalı;

    public GameObject settingsMenu;
    public GameObject pauseMenu;

    public Camera kamera;

    public GameObject lowToggle;
    public GameObject mediumToggle;
    public GameObject highToggle;
    public GameObject ultraToggle;

    public void Start()
    {
        if (PlayerPrefs.GetString("ses") == null)
        {
            anaGirisSes.mute = false;
            sesAcık.SetActive(true);
            sesKapalı.SetActive(false);
        }
        else if (PlayerPrefs.GetString("ses") == "acık")
        {
            anaGirisSes.mute = false;
            sesAcık.SetActive(true);
            sesKapalı.SetActive(false);
        }
        else if (PlayerPrefs.GetString("ses") == "kapalı")
        {
            anaGirisSes.mute = true;
            sesAcık.SetActive(false);
            sesKapalı.SetActive(true);
        }

        if (PlayerPrefs.GetString("soundeffect") == null)
        {
            soundEffectSes.mute = false;
            sesSoundEffectAcık.SetActive(true);
            sesSoundEffectKapalı.SetActive(false);
        }
        else if (PlayerPrefs.GetString("soundeffect") == "acık")
        {
            soundEffectSes.mute = false;
            sesSoundEffectAcık.SetActive(true);
            sesSoundEffectKapalı.SetActive(false);
        }
        else if (PlayerPrefs.GetString("soundeffect") == "kapalı")
        {
            soundEffectSes.mute = true;
            sesSoundEffectAcık.SetActive(false);
            sesSoundEffectKapalı.SetActive(true);
        }

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

    public void SesAcık()
    {
        anaGirisSes.mute = true;
        sesAcık.SetActive(false);
        sesKapalı.SetActive(true);
        PlayerPrefs.SetString("ses", "kapalı");
    }
    public void SesKapalı()
    {
        anaGirisSes.mute = false;
        sesAcık.SetActive(true);
        sesKapalı.SetActive(false);
        PlayerPrefs.SetString("ses", "acık");
    }

    public void SesSoundEffectAcık()
    {
        soundEffectSes.mute = true;
        sesSoundEffectAcık.SetActive(false);
        sesSoundEffectKapalı.SetActive(true);
        PlayerPrefs.SetString("soundeffect", "kapalı");
    }
    public void SesSoundEffectKapalı()
    {
        soundEffectSes.mute = false;
        sesSoundEffectAcık.SetActive(true);
        sesSoundEffectKapalı.SetActive(false);
        PlayerPrefs.SetString("soundeffect", "acık");
    }

    public void Low()
    {
        PlayerPrefs.SetString("kamerafar" , "low");
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

    public void Back()
    {
        pauseMenu.SetActive(true);
        settingsMenu.SetActive(false);
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
