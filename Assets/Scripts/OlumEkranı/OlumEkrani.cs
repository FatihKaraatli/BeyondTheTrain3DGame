using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class OlumEkrani : MonoBehaviour
{
    public GameObject train;
    float lerpNumber = 3;
    private GameObject OyunBittiCanvas;
    GameObject tren;

    public TextMeshProUGUI geriSayım;
    float clock = 3.1f;
    public bool reklam = false;

    public GameObject reklamIzleDevamEt;
    bool reklamTutucu = true;


    public void Start()
    {
        OyunBittiCanvas = GameObject.FindGameObjectWithTag("OyunBitti");
        tren = GameObject.FindGameObjectWithTag("Player");
        reklam = false;
        geriSayım.enabled = false;

        if (PlayerPrefs.GetInt("continue") == 0)
        {
            reklamIzleDevamEt.SetActive(true);
        }
        else
        {
            reklamIzleDevamEt.SetActive(false);
        }
    }
    public void Update()
    {
        if (reklam)
        {
            geriSayım.enabled = true;
            clock = clock - Time.deltaTime;
            geriSayım.text = ((int)(clock)).ToString();
            if (clock <= 0)
            {
                reklam = false;
                geriSayım.enabled = false;
                clock = 3.1f;
            }
        }
    }

    public void ReklamIzle()
    {
        reklam = true;
        PlayerPrefs.SetInt("continue", 1);
        OyunBittiCanvas.GetComponent<Canvas>().enabled = false;
        PlayerPrefs.SetFloat("reklamticket" , PlayerPrefs.GetFloat("ekranticket"));
        PlayerPrefs.SetFloat("reklamskor", PlayerPrefs.GetFloat("skor"));
        PlayerPrefs.SetFloat("reklamhız" , PlayerPrefs.GetFloat("oyunhızı"));
        Time.timeScale = 0f;
        Zaman();
        //tren.GetComponent<Train>().enabled = true;
    }

    public void Restart()
    {
        PlayerPrefs.SetFloat("reklamhızı", 0.0001f);
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("continue", 0);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        SceneManager.LoadScene("AnaGiris");
        PlayerPrefs.SetInt("continue", 0);
        Time.timeScale = 1f;
    }

    public void Zaman()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetString("reklamizlendimi" , "true");
        Time.timeScale = 1f;
    }
}
