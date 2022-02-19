using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioSource trenSesi;
    public GameObject tren;

    public GameObject settingsMenu;

    public bool pause = false;

    public AudioSource anaGirisSes;
    public AudioSource soundEffectSes;

    public Camera kamera;

    public GameObject pauseImage;
    public void Start()
    {
        pauseMenu.SetActive(false);

        if (PlayerPrefs.GetString("ses") == null)
        {
            anaGirisSes.mute = false;
        }
        else if (PlayerPrefs.GetString("ses") == "acık")
        {
            anaGirisSes.mute = false;
        }
        else if (PlayerPrefs.GetString("ses") == "kapalı")
        {
            anaGirisSes.mute = true;
        }

        if (PlayerPrefs.GetString("soundeffect") == null)
        {
            soundEffectSes.mute = false;
        }
        else if (PlayerPrefs.GetString("soundeffect") == "acık")
        {
            soundEffectSes.mute = false;
        }
        else if (PlayerPrefs.GetString("soundeffect") == "kapalı")
        {
            soundEffectSes.mute = true;
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

        if(PlayerPrefs.GetString("reklamizlendimi") == "true")
        {
            PlayerPrefs.SetFloat("ekranticket", PlayerPrefs.GetFloat("reklamticket"));
            PlayerPrefs.SetFloat("skor", PlayerPrefs.GetFloat("reklamskor"));
            PlayerPrefs.SetString("reklamizlendimi", "false");
        }

    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        tren.GetComponent<Train>().enabled = false;
        pause = true;
        Time.timeScale = 0f;
        trenSesi.Pause();
        pauseImage.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        tren.GetComponent<Train>().enabled = true;
        pause = false;
        Time.timeScale = 1f;
        trenSesi.UnPause();
        pauseImage.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MenuyeDon()
    {
        SceneManager.LoadScene("AnaGiris");
        Time.timeScale = 1f;
    }

    public void Settings()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
}

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }





}
