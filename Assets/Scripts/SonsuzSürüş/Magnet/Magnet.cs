using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magnet : MonoBehaviour
{
    public Slider mıknatısSlider;
    public float clock = 0f;

    public GameObject mıknatısCanvas;

    bool magnetAlındı_mı = false;

    void Start()
    {
        clock = 0f;
        mıknatısCanvas.SetActive(false);
        PlayerPrefs.SetString("magnet", "false");
    }
    

    void Update()
    {
        if (magnetAlındı_mı)
        {
            clock = clock + Time.deltaTime;
            mıknatısSlider.value = clock;
        }
    }

    public void MagnetDurdurucu()
    {
        magnetAlındı_mı = false;
        mıknatısCanvas.SetActive(false);
        PlayerPrefs.SetString("magnet", "false");
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "magnet")
        {
            magnetAlındı_mı = true;
            CancelInvoke("MagnetDurdurucu");
            clock = 0f;
            PlayerPrefs.SetString("magnet" , "true");

            if (PlayerPrefs.GetFloat("magnetupgrade") == 1f)
            {
                Invoke("MagnetDurdurucu", 10f);
                mıknatısCanvas.SetActive(true);
                mıknatısSlider.maxValue = 10f;
            }
            else if (PlayerPrefs.GetFloat("magnetupgrade") == 2f)
            {
                Invoke("MagnetDurdurucu", 15f);
                mıknatısCanvas.SetActive(true);
                mıknatısSlider.maxValue = 15f;
            }
            else if (PlayerPrefs.GetFloat("magnetupgrade") == 3f)
            {
                Invoke("MagnetDurdurucu", 20f);
                mıknatısCanvas.SetActive(true);
                mıknatısSlider.maxValue = 20f;
            }
            else if (PlayerPrefs.GetFloat("magnetupgrade") == 4f)
            {
                Invoke("MagnetDurdurucu", 25f);
                mıknatısCanvas.SetActive(true);
                mıknatısSlider.maxValue = 25f;
            }
            else if (PlayerPrefs.GetFloat("magnetupgrade") == 5f)
            {
                Invoke("MagnetDurdurucu", 30f);
                mıknatısCanvas.SetActive(true);
                mıknatısSlider.maxValue = 30f;
            }
            else
            {
                Invoke("MagnetDurdurucu", 10f);
                mıknatısCanvas.SetActive(true);
                mıknatısSlider.maxValue = 10f;
            }
        }
    }
}
