using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModKontroller : MonoBehaviour
{
    public GameObject anaGiris;
    public GameObject mods;

    public GameObject uzakKamera;
    public GameObject kameraNesne;
    public GameObject uzakKameraModCanvas;
    public GameObject uzakKameraKilitAc;
    public GameObject uzakKameraSec;
    public GameObject uzakKameraKilit;
    public GameObject uzakKameraUcret;
    public TextMeshProUGUI uzakKameraUcretText;
    public bool uzakKameraAlınabilir_mi = false;
    public GameObject normalKameraButton;
    public GameObject uzakKameraBonus;

    public GameObject gece;
    public GameObject geceModCanvas;
    public GameObject geceKilitAc;
    public GameObject geceSec;
    public GameObject geceKilit;
    public GameObject geceUcret;
    public TextMeshProUGUI geceUcretText;
    public bool geceAlınabilir_mi = false;
    public GameObject normalGunduz;
    public GameObject geceBonus;

    public GameObject dust;
    public GameObject dustModCanvas;
    public GameObject dustKilitAc;
    public GameObject dustSec;
    public GameObject dustKilit;
    public GameObject dustUcret;
    public TextMeshProUGUI dustUcretText;
    public bool dustAlınabilir_mi = false;
    public GameObject normalDust;
    public GameObject dustBonus;


    int count = 0;
    public TextMeshProUGUI skor;
    public float lerpNumber = 3f;
    bool kameraDonmeli_mi = true;

    public Material gunduzMaterial;
    public Material geceMaterial;

    public GameObject classicFar;
    public GameObject hybridFar;
    public GameObject exclusiveFar;
    public GameObject capsuleFar;
    public GameObject KF2500Far;
    public GameObject tramFar;
    public GameObject tankFar;
    public GameObject spaceFar;
    public GameObject toyFar;

    public GameObject gunes;
    public GameObject cityIsık;

    public GameObject kameraYakınToggle;
    public GameObject kameraNormalToggle;
    public GameObject geceToggle;
    public GameObject gunduzToggle;
    public GameObject dustAcıkToggle;
    public GameObject dustKapalıToggle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skor.text = "" + PlayerPrefs.GetFloat("ticket");

        ToggleChoose();

        if (count == 0)
        {
            kameraDonmeli_mi = true;
            kameraNesne.GetComponent<KameraRotate>().enabled = false;
            kameraNesne.GetComponent<KameraPosition>().enabled = false;
            uzakKamera.transform.rotation = Quaternion.Lerp(uzakKamera.transform.rotation , Quaternion.Euler(1.798f, -140.073f, 0.07300001f) , Time.deltaTime * lerpNumber);
            uzakKamera.transform.position = Vector3.Lerp(uzakKamera.transform.position, new Vector3(-1.88f, -0.51f, -1.05f), Time.deltaTime * lerpNumber);
            uzakKameraModCanvas.SetActive(true);
            uzakKameraBonus.SetActive(true);
            if (PlayerPrefs.GetString("uzakKameraAlınabilir_mi") != "true")
            {
                uzakKameraKilitAc.SetActive(true);
                uzakKameraSec.SetActive(false);
                uzakKameraKilit.SetActive(true);
                uzakKameraUcret.SetActive(true);
                uzakKameraUcretText.text = "PRICE:20.000";
                normalKameraButton.SetActive(false);
            }   
            else
            {
                uzakKameraKilitAc.SetActive(false);
                uzakKameraSec.SetActive(true);
                uzakKameraKilit.SetActive(false);
                uzakKameraUcret.SetActive(false);
                uzakKameraUcretText.text = "";
                normalKameraButton.SetActive(true);
            }

            Gunduz();
            geceBonus.SetActive(false);
            geceModCanvas.SetActive(false);
            geceKilitAc.SetActive(false);
            geceSec.SetActive(false);
            geceKilit.SetActive(false);
            geceUcret.SetActive(false);
            geceUcretText.text = "";
            normalGunduz.SetActive(false);

            dust.SetActive(false);
            dustBonus.SetActive(false);
            dustModCanvas.SetActive(false);
            dustKilitAc.SetActive(false);
            dustSec.SetActive(false);
            dustKilit.SetActive(false);
            dustUcret.SetActive(false);
            dustUcretText.text = "";
            normalDust.SetActive(false);

        }
        else if (count == 1)
        {
            if (kameraDonmeli_mi)
            {
                KameraKontrol();
                kameraDonmeli_mi = false;
            }
            uzakKameraBonus.SetActive(false);
            uzakKameraModCanvas.SetActive(false);
            uzakKameraKilitAc.SetActive(false);
            uzakKameraSec.SetActive(false);
            uzakKameraKilit.SetActive(false);
            uzakKameraUcret.SetActive(false);
            uzakKameraUcretText.text = "";
            normalKameraButton.SetActive(false);

            Gece();
            geceModCanvas.SetActive(true);
            geceBonus.SetActive(true);
            if (PlayerPrefs.GetString("geceAlınabilir_mi") != "true")
            {
                geceKilitAc.SetActive(true);
                geceSec.SetActive(false);
                geceKilit.SetActive(true);
                geceUcret.SetActive(true);
                geceUcretText.text = "PRICE:40.000";
                normalGunduz.SetActive(false);
            }
            else
            {
                geceKilitAc.SetActive(false);
                geceSec.SetActive(true);
                geceKilit.SetActive(false);
                geceUcret.SetActive(false);
                geceUcretText.text = "";
                normalGunduz.SetActive(true);
            }

            dust.SetActive(false);
            dustBonus.SetActive(false);
            dustModCanvas.SetActive(false);
            dustKilitAc.SetActive(false);
            dustSec.SetActive(false);
            dustKilit.SetActive(false);
            dustUcret.SetActive(false);
            dustUcretText.text = "";
            normalDust.SetActive(false);
        }
        else if (count == 2)
        {
            if (kameraDonmeli_mi)
            {
                KameraKontrol();
                kameraDonmeli_mi = false;
            }
            uzakKameraBonus.SetActive(false);
            uzakKameraModCanvas.SetActive(false);
            uzakKameraKilitAc.SetActive(false);
            uzakKameraSec.SetActive(false);
            uzakKameraKilit.SetActive(false);
            uzakKameraUcret.SetActive(false);
            uzakKameraUcretText.text = "";
            normalKameraButton.SetActive(false);

            Gunduz();
            geceBonus.SetActive(false);
            geceModCanvas.SetActive(false);
            geceKilitAc.SetActive(false);
            geceSec.SetActive(false);
            geceKilit.SetActive(false);
            geceUcret.SetActive(false);
            geceUcretText.text = "";
            normalGunduz.SetActive(false);

            dust.SetActive(true);
            dustModCanvas.SetActive(true);
            dustBonus.SetActive(true);
            if (PlayerPrefs.GetString("dustAlınabilir_mi") != "true")
            {
                dustKilitAc.SetActive(true);
                dustSec.SetActive(false);
                dustKilit.SetActive(true);
                dustUcret.SetActive(true);
                dustUcretText.text = "PRICE:60.000";
                normalDust.SetActive(false);
            }
            else
            {
                dustKilitAc.SetActive(false);
                dustSec.SetActive(true);
                dustKilit.SetActive(false);
                dustUcret.SetActive(false);
                dustUcretText.text = "";
                normalDust.SetActive(true);
            }
        }
        else if (count == 3)
        {
            count = 0;
        }

        else if (count == -1)
        {
            if (kameraDonmeli_mi)
            {
                KameraKontrol();
                kameraDonmeli_mi = false;
            }
            uzakKameraBonus.SetActive(false);
            uzakKameraModCanvas.SetActive(false);
            uzakKameraKilitAc.SetActive(false);
            uzakKameraSec.SetActive(false);
            uzakKameraKilit.SetActive(false);
            uzakKameraUcret.SetActive(false);
            uzakKameraUcretText.text = "";
            normalKameraButton.SetActive(false);

            Gunduz();
            geceBonus.SetActive(false);
            geceModCanvas.SetActive(false);
            geceKilitAc.SetActive(false);
            geceSec.SetActive(false);
            geceKilit.SetActive(false);
            geceUcret.SetActive(false);
            geceUcretText.text = "";
            normalGunduz.SetActive(false);

            dust.SetActive(true);
            dustModCanvas.SetActive(true);
            dustBonus.SetActive(true);
            if (PlayerPrefs.GetString("dustAlınabilir_mi") != "true")
            {
                dustKilitAc.SetActive(true);
                dustSec.SetActive(false);
                dustKilit.SetActive(true);
                dustUcret.SetActive(true);
                dustUcretText.text = "PRICE:60.000";
                normalDust.SetActive(false);
            }
            else
            {
                dustKilitAc.SetActive(false);
                dustSec.SetActive(true);
                dustKilit.SetActive(false);
                dustUcret.SetActive(false);
                dustUcretText.text = "";
                normalDust.SetActive(true);
            }
        }
        else if (count == -2)
        {
            if (kameraDonmeli_mi)
            {
                KameraKontrol();
                kameraDonmeli_mi = false;
            }
            uzakKameraBonus.SetActive(false);
            uzakKameraModCanvas.SetActive(false);
            uzakKameraKilitAc.SetActive(false);
            uzakKameraSec.SetActive(false);
            uzakKameraKilit.SetActive(false);
            uzakKameraUcret.SetActive(false);
            uzakKameraUcretText.text = "";
            normalKameraButton.SetActive(false);

            Gece();
            geceModCanvas.SetActive(true);
            geceBonus.SetActive(true);
            if (PlayerPrefs.GetString("geceAlınabilir_mi") != "true")
            {
                geceKilitAc.SetActive(true);
                geceSec.SetActive(false);
                geceKilit.SetActive(true);
                geceUcret.SetActive(true);
                geceUcretText.text = "PRICE:40.000";
                normalGunduz.SetActive(false);
            }
            else
            {
                geceKilitAc.SetActive(false);
                geceSec.SetActive(true);
                geceKilit.SetActive(false);
                geceUcret.SetActive(false);
                geceUcretText.text = "";
                normalGunduz.SetActive(true);
            }
            
            dust.SetActive(false);
            dustBonus.SetActive(false);
            dustModCanvas.SetActive(false);
            dustKilitAc.SetActive(false);
            dustSec.SetActive(false);
            dustKilit.SetActive(false);
            dustUcret.SetActive(false);
            dustUcretText.text = "";
            normalDust.SetActive(false);
        }
        else if (count == -3)
        {
            count = 0;
        }

    }


    public void KameraUzakButton()
    {
        PlayerPrefs.SetString("kameramod", "uzakkamera");

    }
    public void KameraYakınButton()
    {
        PlayerPrefs.SetString("kameramod", "yakınkamera");
    }

    public void GeceButton()
    {
        PlayerPrefs.SetString("gecemod", "gece");
    }

    public void GunduzButton()
    {
        PlayerPrefs.SetString("gecemod", "gunduz");
    }

    public void DustAçıkButton()
    {
        PlayerPrefs.SetString("dust", "dustaçık");
    }

    public void DustKapalıButton()
    {
        PlayerPrefs.SetString("dust", "dustkapalı");
    }

    public void KameraYakınBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 100000)
        {
            uzakKameraAlınabilir_mi = true;
            PlayerPrefs.SetString("uzakKameraAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 100000);
        }
    }
    public void GeceBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 150000)
        {
            geceAlınabilir_mi = true;
            PlayerPrefs.SetString("geceAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 150000);
        }
    }

    public void DustBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 300000)
        {
            dustAlınabilir_mi = true;
            PlayerPrefs.SetString("dustAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 300000);
        }
    }



    public void ToggleChoose()
    {
        if (PlayerPrefs.GetString("kameramod") == "uzakkamera")
        {
            kameraNormalToggle.SetActive(true);
            kameraYakınToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("kameramod") == "yakınkamera")
        {
            kameraNormalToggle.SetActive(false);
            kameraYakınToggle.SetActive(true);
        }
        else
        {
            kameraNormalToggle.SetActive(true);
            kameraYakınToggle.SetActive(false);
        }

        if (PlayerPrefs.GetString("gecemod") == "gece")
        {
            geceToggle.SetActive(true);
            gunduzToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("gecemod") == null)
        {
            geceToggle.SetActive(false);
            gunduzToggle.SetActive(true);
        }
        else
        {
            geceToggle.SetActive(false);
            gunduzToggle.SetActive(true);
        }

        if (PlayerPrefs.GetString("dust") == "dustaçık")
        {
            dustAcıkToggle.SetActive(true);
            dustKapalıToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("dust") == "dustkapalı")
        {
            dustAcıkToggle.SetActive(false);
            dustKapalıToggle.SetActive(true);
        }
        else
        {
            dustAcıkToggle.SetActive(false);
            dustKapalıToggle.SetActive(true);
        }
    }


    public void RightButton()
    {
        count++;
        KameraKontrol();
    }

    public void LeftButton()
    {
        count--;
        KameraKontrol();
    }

    public void BackButton()
    {
        KameraKontrol();
        Gunduz();
        dust.SetActive(false);
        mods.SetActive(false);
        anaGiris.SetActive(true);
    }

    public void KameraKontrol()
    {
        kameraNesne.GetComponent<KameraRotate>().enabled = true;
        kameraNesne.GetComponent<KameraPosition>().enabled = true;
        uzakKamera.transform.rotation = Quaternion.Lerp(uzakKamera.transform.rotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * lerpNumber);
        uzakKamera.transform.position = Vector3.Lerp(uzakKamera.transform.position, new Vector3(-0.247f, 0, 1.318f), Time.deltaTime * lerpNumber);
    }

    public void Gunduz()
    {
        RenderSettings.skybox = gunduzMaterial;
        classicFar.SetActive(false);
        hybridFar.SetActive(false);
        exclusiveFar.SetActive(false);
        capsuleFar.SetActive(false);
        KF2500Far.SetActive(false);
        tramFar.SetActive(false);
        tankFar.SetActive(false);
        spaceFar.SetActive(false);
        toyFar.SetActive(false);
        gunes.SetActive(true);
        cityIsık.SetActive(true);
    }

    public void Gece()
    {
        RenderSettings.skybox = geceMaterial;
        classicFar.SetActive(true);
        hybridFar.SetActive(true);
        exclusiveFar.SetActive(true);
        capsuleFar.SetActive(true);
        KF2500Far.SetActive(true);
        tramFar.SetActive(true);
        tankFar.SetActive(true);
        spaceFar.SetActive(true);
        toyFar.SetActive(true);
        gunes.SetActive(false);
        cityIsık.SetActive(false);
    }

}
