using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SesAyarlari : MonoBehaviour
{
    public AudioSource anaGirisSes;

    public GameObject sesAcık;
    public GameObject sesKapalı;

    public GameObject sesSoundEffectAcık;
    public GameObject sesSoundEffectKapalı;

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
            sesSoundEffectAcık.SetActive(true);
            sesSoundEffectKapalı.SetActive(false);
        }
        else if (PlayerPrefs.GetString("soundeffect") == "acık")
        {
            sesSoundEffectAcık.SetActive(true);
            sesSoundEffectKapalı.SetActive(false);
        }
        else if (PlayerPrefs.GetString("soundeffect") == "kapalı")
        {
            sesSoundEffectAcık.SetActive(false);
            sesSoundEffectKapalı.SetActive(true);
        }
    }

    public void SesAcık()
    {
        anaGirisSes.mute = true;
        sesAcık.SetActive(false);
        sesKapalı.SetActive(true);
        PlayerPrefs.SetString("ses" , "kapalı");
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
        sesSoundEffectAcık.SetActive(false);
        sesSoundEffectKapalı.SetActive(true);
        PlayerPrefs.SetString("soundeffect", "kapalı");
    }
    public void SesSoundEffectKapalı()
    {
        sesSoundEffectAcık.SetActive(true);
        sesSoundEffectKapalı.SetActive(false);
        PlayerPrefs.SetString("soundeffect", "acık");
    }
}
