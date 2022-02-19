using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeKontrol : MonoBehaviour
{
    public GameObject upgrades;
    public GameObject anaGiris;

    public GameObject magnetFiyat10k;
    public GameObject magnetFiyat20k;
    public GameObject magnetFiyat40k;
    public GameObject magnetFiyat60k;
    public TextMeshProUGUI magnet15s;
    public TextMeshProUGUI magnet20s;
    public TextMeshProUGUI magnet25s;
    public TextMeshProUGUI magnet30s;
    public GameObject magnetTick;

    public GameObject x2Fiyat10k;
    public GameObject x2Fiyat20k;
    public GameObject x2Fiyat40k;
    public GameObject x2Fiyat60k;
    public TextMeshProUGUI x215s;
    public TextMeshProUGUI x220s;
    public TextMeshProUGUI x225s;
    public TextMeshProUGUI x230s;
    public GameObject x2Tick;

    public GameObject x4Fiyat20k;
    public GameObject x4Fiyat40k;
    public GameObject x4Fiyat60k;
    public GameObject x4Fiyat100k;
    public TextMeshProUGUI x415s;
    public TextMeshProUGUI x420s;
    public TextMeshProUGUI x425s;
    public TextMeshProUGUI x430s;
    public GameObject x4Tick;

    public TextMeshProUGUI skor;

    void Start()
    {
        if (PlayerPrefs.GetFloat("magnetupgrade") != 2f && PlayerPrefs.GetFloat("magnetupgrade") != 3f && PlayerPrefs.GetFloat("magnetupgrade") != 4f && PlayerPrefs.GetFloat("magnetupgrade") != 5f)
        {
            PlayerPrefs.SetFloat("magnetupgrade", 1f);
        }

        if (PlayerPrefs.GetFloat("x2upgrade") != 2f && PlayerPrefs.GetFloat("x2upgrade") != 3f && PlayerPrefs.GetFloat("x2upgrade") != 4f && PlayerPrefs.GetFloat("x2upgrade") != 5f)
        {
            PlayerPrefs.SetFloat("x2upgrade", 1f);
        }

        if (PlayerPrefs.GetFloat("x4upgrade") != 2f && PlayerPrefs.GetFloat("x4upgrade") != 3f && PlayerPrefs.GetFloat("x4upgrade") != 4f && PlayerPrefs.GetFloat("x4upgrade") != 5f)
        {
            PlayerPrefs.SetFloat("x4upgrade", 1f);
        }
    }

    
    void Update()
    {
        skor.text = "" + PlayerPrefs.GetFloat("ticket");

        Magnet();
        X2();
        X4();
    }

    public void Magnet()
    {
        if (PlayerPrefs.GetFloat("magnetupgrade") == 1f)
        {
            magnetFiyat10k.SetActive(true);
            magnetFiyat20k.SetActive(false);
            magnetFiyat40k.SetActive(false);
            magnetFiyat60k.SetActive(false);
            magnetTick.SetActive(false);
            magnet15s.color = new Color32(182, 40, 40, 255);
            magnet20s.color = new Color32(182, 40, 40, 255);
            magnet25s.color = new Color32(182, 40, 40, 255);
            magnet30s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("magnetupgrade") == 2f)
        {
            magnetFiyat10k.SetActive(false);
            magnetFiyat20k.SetActive(true);
            magnetFiyat40k.SetActive(false);
            magnetFiyat60k.SetActive(false);
            magnetTick.SetActive(false);
            magnet15s.color = new Color32(35, 139, 98, 255);
            magnet20s.color = new Color32(182, 40, 40, 255);
            magnet25s.color = new Color32(182, 40, 40, 255);
            magnet30s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("magnetupgrade") == 3f)
        {
            magnetFiyat10k.SetActive(false);
            magnetFiyat20k.SetActive(false);
            magnetFiyat40k.SetActive(true);
            magnetFiyat60k.SetActive(false);
            magnetTick.SetActive(false);
            magnet15s.color = new Color32(35, 139, 98, 255);
            magnet20s.color = new Color32(35, 139, 98, 255);
            magnet25s.color = new Color32(182, 40, 40, 255);
            magnet30s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("magnetupgrade") == 4f)
        {
            magnetFiyat10k.SetActive(false);
            magnetFiyat20k.SetActive(false);
            magnetFiyat40k.SetActive(false);
            magnetFiyat60k.SetActive(true);
            magnetTick.SetActive(false);
            magnet15s.color = new Color32(35, 139, 98, 255);
            magnet20s.color = new Color32(35, 139, 98, 255);
            magnet25s.color = new Color32(35, 139, 98, 255);
            magnet30s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("magnetupgrade") == 5f)
        {
            magnetFiyat10k.SetActive(false);
            magnetFiyat20k.SetActive(false);
            magnetFiyat40k.SetActive(false);
            magnetFiyat60k.SetActive(false);
            magnetTick.SetActive(true);
            magnet15s.color = new Color32(35, 139, 98, 255);
            magnet20s.color = new Color32(35, 139, 98, 255);
            magnet25s.color = new Color32(35, 139, 98, 255);
            magnet30s.color = new Color32(35, 139, 98, 255);
        }
    }

    public void X2()
    {
        if (PlayerPrefs.GetFloat("x2upgrade") == 1f)
        {
            x2Fiyat10k.SetActive(true);
            x2Fiyat20k.SetActive(false);
            x2Fiyat40k.SetActive(false);
            x2Fiyat60k.SetActive(false);
            x2Tick.SetActive(false);
            x215s.color = new Color32(182, 40, 40, 255);
            x220s.color = new Color32(182, 40, 40, 255);
            x225s.color = new Color32(182, 40, 40, 255);
            x230s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("x2upgrade") == 2f)
        {
            x2Fiyat10k.SetActive(false);
            x2Fiyat20k.SetActive(true);
            x2Fiyat40k.SetActive(false);
            x2Fiyat60k.SetActive(false);
            x2Tick.SetActive(false);
            x215s.color = new Color32(35, 139, 98, 255);
            x220s.color = new Color32(182, 40, 40, 255);
            x225s.color = new Color32(182, 40, 40, 255);
            x230s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("x2upgrade") == 3f)
        {
            x2Fiyat10k.SetActive(false);
            x2Fiyat20k.SetActive(false);
            x2Fiyat40k.SetActive(true);
            x2Fiyat60k.SetActive(false);
            x2Tick.SetActive(false);
            x215s.color = new Color32(35, 139, 98, 255);
            x220s.color = new Color32(35, 139, 98, 255);
            x225s.color = new Color32(182, 40, 40, 255);
            x230s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("x2upgrade") == 4f)
        {
            x2Fiyat10k.SetActive(false);
            x2Fiyat20k.SetActive(false);
            x2Fiyat40k.SetActive(false);
            x2Fiyat60k.SetActive(true);
            x2Tick.SetActive(false);
            x215s.color = new Color32(35, 139, 98, 255);
            x220s.color = new Color32(35, 139, 98, 255);
            x225s.color = new Color32(35, 139, 98, 255);
            x230s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("x2upgrade") == 5f)
        {
            x2Fiyat10k.SetActive(false);
            x2Fiyat20k.SetActive(false);
            x2Fiyat40k.SetActive(false);
            x2Fiyat60k.SetActive(false);
            x2Tick.SetActive(true);
            x215s.color = new Color32(35, 139, 98, 255);
            x220s.color = new Color32(35, 139, 98, 255);
            x225s.color = new Color32(35, 139, 98, 255);
            x230s.color = new Color32(35, 139, 98, 255);
        }
    }

    public void X4()
    {
        if (PlayerPrefs.GetFloat("x4upgrade") == 1f)
        {
            x4Fiyat20k.SetActive(true);
            x4Fiyat40k.SetActive(false);
            x4Fiyat60k.SetActive(false);
            x4Fiyat100k.SetActive(false);
            x4Tick.SetActive(false);
            x415s.color = new Color32(182, 40, 40, 255);
            x420s.color = new Color32(182, 40, 40, 255);
            x425s.color = new Color32(182, 40, 40, 255);
            x430s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("x4upgrade") == 2f)
        {
            x4Fiyat20k.SetActive(false);
            x4Fiyat40k.SetActive(true);
            x4Fiyat60k.SetActive(false);
            x4Fiyat100k.SetActive(false);
            x4Tick.SetActive(false);
            x415s.color = new Color32(35, 139, 98, 255);
            x420s.color = new Color32(182, 40, 40, 255);
            x425s.color = new Color32(182, 40, 40, 255);
            x430s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("x4upgrade") == 3f)
        {
            x4Fiyat20k.SetActive(false);
            x4Fiyat40k.SetActive(false);
            x4Fiyat60k.SetActive(true);
            x4Fiyat100k.SetActive(false);
            x4Tick.SetActive(false);
            x415s.color = new Color32(35, 139, 98, 255);
            x420s.color = new Color32(35, 139, 98, 255);
            x425s.color = new Color32(182, 40, 40, 255);
            x430s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("x4upgrade") == 4f)
        {
            x4Fiyat20k.SetActive(false);
            x4Fiyat40k.SetActive(false);
            x4Fiyat60k.SetActive(false);
            x4Fiyat100k.SetActive(true);
            x4Tick.SetActive(false);
            x415s.color = new Color32(35, 139, 98, 255);
            x420s.color = new Color32(35, 139, 98, 255);
            x425s.color = new Color32(35, 139, 98, 255);
            x430s.color = new Color32(182, 40, 40, 255);
        }
        else if (PlayerPrefs.GetFloat("x4upgrade") == 5f)
        {
            x4Fiyat20k.SetActive(false);
            x4Fiyat40k.SetActive(false);
            x4Fiyat60k.SetActive(false);
            x4Fiyat100k.SetActive(false);
            x4Tick.SetActive(true);
            x415s.color = new Color32(35, 139, 98, 255);
            x420s.color = new Color32(35, 139, 98, 255);
            x425s.color = new Color32(35, 139, 98, 255);
            x430s.color = new Color32(35, 139, 98, 255);
        }
    }

    public void MagnetFiyat10K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 10000)
        {
            PlayerPrefs.SetFloat("magnetupgrade", 2f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 10000);
        }
    }
    public void MagnetFiyat20K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 20000)
        {
            PlayerPrefs.SetFloat("magnetupgrade", 3f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 20000);
        }
    }
    public void MagnetFiyat40K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 40000)
        {
            PlayerPrefs.SetFloat("magnetupgrade", 4f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 40000);
        }
    }
    public void MagnetFiyat60K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 60000)
        {
            PlayerPrefs.SetFloat("magnetupgrade", 5f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 60000);
        }
    }

    public void X2Fiyat10K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 10000)
        {
            PlayerPrefs.SetFloat("x2upgrade", 2f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 10000);
        }
    }
    public void X2Fiyat20K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 20000)
        {
            PlayerPrefs.SetFloat("x2upgrade", 3f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 20000);
        }
    }
    public void X2Fiyat40K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 40000)
        {
            PlayerPrefs.SetFloat("x2upgrade", 4f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 40000);
        }
    }
    public void X2Fiyat60K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 60000)
        {
            PlayerPrefs.SetFloat("x2upgrade", 5f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 60000);
        }
    }

    public void X4Fiyat20K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 20000)
        {
            PlayerPrefs.SetFloat("x4upgrade", 2f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 20000);
        }
    }
    public void X4Fiyat40K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 40000)
        {
            PlayerPrefs.SetFloat("x4upgrade", 3f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 40000);
        }
    }
    public void X4Fiyat60K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 60000)
        {
            PlayerPrefs.SetFloat("x4upgrade", 4f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 60000);
        }
    }
    public void X4Fiyat100K()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 100000)
        {
            PlayerPrefs.SetFloat("x4upgrade", 5f);
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 100000);
        }
    }


    public void Back()
    {
        upgrades.SetActive(false);
        anaGiris.SetActive(true);
    }
}
