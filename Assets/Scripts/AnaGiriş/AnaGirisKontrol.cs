using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnaGirisKontrol : MonoBehaviour
{
    public GameObject anaGiris;
    public GameObject settings;
    public GameObject store;
    public GameObject lokomotifStore;
    public GameObject environmentStore;
    public GameObject mods;
    public GameObject upgrades;

    bool kontrol = true;

    public TextMeshProUGUI highScore;

    public GameObject forestEnvironment;
    public GameObject bridgeEnvironment;
    public GameObject desertEnvironment;
    public GameObject graveyardEnvironment;
    public GameObject cityEnvironment;
    public GameObject toyCityEnvironment;

    public GameObject classicLokomotive;
    public GameObject hybridLokomotive;
    public GameObject exclusiveLokomotive;
    public GameObject capsuleLokomotive;
    public GameObject kf2500Lokomotive;
    public GameObject tramLokomotive;
    public GameObject tankLokomotive;
    public GameObject spaceLokomotive;
    public GameObject toyLokomotive;

    public GameObject classicCarriage;
    public GameObject passengerCarriage;
    public GameObject coalCarriage;
    public GameObject containerCarriage;
    public GameObject spaceCarriage;
    public GameObject tramCarriage;
    public GameObject toyCarriage;

    public AudioSource anaGirisSes;

    public Camera kamera;

    public void Start()
    {
        store.SetActive(false);
        lokomotifStore.SetActive(true);
        lokomotifStore.SetActive(false);
        environmentStore.SetActive(false);
        mods.SetActive(false);
        upgrades.SetActive(false);

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

        if (PlayerPrefs.GetString("environment") == "forest")
        {
            forestEnvironment.SetActive(true);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toyCityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "bridge")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(true);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toyCityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "desert")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(true);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toyCityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "graveyard")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(true);
            cityEnvironment.SetActive(false);
            toyCityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "city")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(true);
            toyCityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "toycity")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toyCityEnvironment.SetActive(true);
        }

        if (PlayerPrefs.GetString("lokomotive") == "classic")
        {
            classicLokomotive.SetActive(true);
            hybridLokomotive.SetActive(false);
            exclusiveLokomotive.SetActive(false);
            capsuleLokomotive.SetActive(false);
            kf2500Lokomotive.SetActive(false);
            tramLokomotive.SetActive(false);
            tankLokomotive.SetActive(false);
            spaceLokomotive.SetActive(false);
            toyLokomotive.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "hybrid")
        {
            classicLokomotive.SetActive(false);
            hybridLokomotive.SetActive(true);
            exclusiveLokomotive.SetActive(false);
            capsuleLokomotive.SetActive(false);
            kf2500Lokomotive.SetActive(false);
            tramLokomotive.SetActive(false);
            tankLokomotive.SetActive(false);
            spaceLokomotive.SetActive(false);
            toyLokomotive.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "exclusive")
        {
            classicLokomotive.SetActive(false);
            hybridLokomotive.SetActive(false);
            exclusiveLokomotive.SetActive(true);
            capsuleLokomotive.SetActive(false);
            kf2500Lokomotive.SetActive(false);
            tramLokomotive.SetActive(false);
            tankLokomotive.SetActive(false);
            spaceLokomotive.SetActive(false);
            toyLokomotive.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "capsule")
        {
            classicLokomotive.SetActive(false);
            hybridLokomotive.SetActive(false);
            exclusiveLokomotive.SetActive(false);
            capsuleLokomotive.SetActive(true);
            kf2500Lokomotive.SetActive(false);
            tramLokomotive.SetActive(false);
            tankLokomotive.SetActive(false);
            spaceLokomotive.SetActive(false);
            toyLokomotive.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "kf2500")
        {
            classicLokomotive.SetActive(false);
            hybridLokomotive.SetActive(false);
            exclusiveLokomotive.SetActive(false);
            capsuleLokomotive.SetActive(false);
            kf2500Lokomotive.SetActive(true);
            tramLokomotive.SetActive(false);
            tankLokomotive.SetActive(false);
            spaceLokomotive.SetActive(false);
            toyLokomotive.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "tram")
        {
            classicLokomotive.SetActive(false);
            hybridLokomotive.SetActive(false);
            exclusiveLokomotive.SetActive(false);
            capsuleLokomotive.SetActive(false);
            kf2500Lokomotive.SetActive(false);
            tramLokomotive.SetActive(true);
            tankLokomotive.SetActive(false);
            spaceLokomotive.SetActive(false);
            toyLokomotive.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "tank")
        {
            classicLokomotive.SetActive(false);
            hybridLokomotive.SetActive(false);
            exclusiveLokomotive.SetActive(false);
            capsuleLokomotive.SetActive(false);
            kf2500Lokomotive.SetActive(false);
            tramLokomotive.SetActive(false);
            tankLokomotive.SetActive(true);
            spaceLokomotive.SetActive(false);
            toyLokomotive.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "space")
        {
            classicLokomotive.SetActive(false);
            hybridLokomotive.SetActive(false);
            exclusiveLokomotive.SetActive(false);
            capsuleLokomotive.SetActive(false);
            kf2500Lokomotive.SetActive(false);
            tramLokomotive.SetActive(false);
            tankLokomotive.SetActive(false);
            spaceLokomotive.SetActive(true);
            toyLokomotive.SetActive(false);
        }
        else if (PlayerPrefs.GetString("lokomotive") == "toy")
        {
            classicLokomotive.SetActive(false);
            hybridLokomotive.SetActive(false);
            exclusiveLokomotive.SetActive(false);
            capsuleLokomotive.SetActive(false);
            kf2500Lokomotive.SetActive(false);
            tramLokomotive.SetActive(false);
            tankLokomotive.SetActive(false);
            spaceLokomotive.SetActive(false);
            toyLokomotive.SetActive(true);
        }

        if (PlayerPrefs.GetString("carriage") == "classic")
        {
            classicCarriage.SetActive(true);
            passengerCarriage.SetActive(false);
            coalCarriage.SetActive(false);
            containerCarriage.SetActive(false);
            spaceCarriage.SetActive(false);
            tramCarriage.SetActive(false);
            toyCarriage.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "passenger")
        {
            classicCarriage.SetActive(false);
            passengerCarriage.SetActive(true);
            coalCarriage.SetActive(false);
            containerCarriage.SetActive(false);
            spaceCarriage.SetActive(false);
            tramCarriage.SetActive(false);
            toyCarriage.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "coal")
        {
            classicCarriage.SetActive(false);
            passengerCarriage.SetActive(false);
            coalCarriage.SetActive(true);
            containerCarriage.SetActive(false);
            spaceCarriage.SetActive(false);
            tramCarriage.SetActive(false);
            toyCarriage.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "container")
        {
            classicCarriage.SetActive(false);
            passengerCarriage.SetActive(false);
            coalCarriage.SetActive(false);
            containerCarriage.SetActive(true);
            spaceCarriage.SetActive(false);
            tramCarriage.SetActive(false);
            toyCarriage.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "space")
        {
            classicCarriage.SetActive(false);
            passengerCarriage.SetActive(false);
            coalCarriage.SetActive(false);
            containerCarriage.SetActive(false);
            spaceCarriage.SetActive(true);
            tramCarriage.SetActive(false);
            toyCarriage.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "space")
        {
            classicCarriage.SetActive(false);
            passengerCarriage.SetActive(false);
            coalCarriage.SetActive(false);
            containerCarriage.SetActive(false);
            spaceCarriage.SetActive(false);
            tramCarriage.SetActive(true);
            toyCarriage.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "toy")
        {
            classicCarriage.SetActive(false);
            passengerCarriage.SetActive(false);
            coalCarriage.SetActive(false);
            containerCarriage.SetActive(false);
            spaceCarriage.SetActive(false);
            tramCarriage.SetActive(false);
            toyCarriage.SetActive(true);
        }

    }

    public void Update()
    {
        highScore.text = "" + PlayerPrefs.GetFloat("highScore");

        if (kontrol)
        {
            if (PlayerPrefs.GetString("environment") == "forest")
            {
                forestEnvironment.SetActive(true);
                bridgeEnvironment.SetActive(false);
                desertEnvironment.SetActive(false);
                graveyardEnvironment.SetActive(false);
                cityEnvironment.SetActive(false);
                toyCityEnvironment.SetActive(false);
            }
            else if (PlayerPrefs.GetString("environment") == "bridge")
            {
                forestEnvironment.SetActive(false);
                bridgeEnvironment.SetActive(true);
                desertEnvironment.SetActive(false);
                graveyardEnvironment.SetActive(false);
                cityEnvironment.SetActive(false);
                toyCityEnvironment.SetActive(false);
            }
            else if (PlayerPrefs.GetString("environment") == "desert")
            {
                forestEnvironment.SetActive(false);
                bridgeEnvironment.SetActive(false);
                desertEnvironment.SetActive(true);
                graveyardEnvironment.SetActive(false);
                cityEnvironment.SetActive(false);
                toyCityEnvironment.SetActive(false);
            }
            else if (PlayerPrefs.GetString("environment") == "graveyard")
            {
                forestEnvironment.SetActive(false);
                bridgeEnvironment.SetActive(false);
                desertEnvironment.SetActive(false);
                graveyardEnvironment.SetActive(true);
                cityEnvironment.SetActive(false);
                toyCityEnvironment.SetActive(false);
            }
            else if (PlayerPrefs.GetString("environment") == "city")
            {
                forestEnvironment.SetActive(false);
                bridgeEnvironment.SetActive(false);
                desertEnvironment.SetActive(false);
                graveyardEnvironment.SetActive(false);
                cityEnvironment.SetActive(true);
                toyCityEnvironment.SetActive(false);
            }
            else if (PlayerPrefs.GetString("environment") == "toycity")
            {
                forestEnvironment.SetActive(false);
                bridgeEnvironment.SetActive(false);
                desertEnvironment.SetActive(false);
                graveyardEnvironment.SetActive(false);
                cityEnvironment.SetActive(false);
                toyCityEnvironment.SetActive(true);
            }

            if (PlayerPrefs.GetString("lokomotive") == "classic")
            {
                classicLokomotive.SetActive(true);
                hybridLokomotive.SetActive(false);
                exclusiveLokomotive.SetActive(false);
                capsuleLokomotive.SetActive(false);
                kf2500Lokomotive.SetActive(false);
                tramLokomotive.SetActive(false);
                tankLokomotive.SetActive(false);
                spaceLokomotive.SetActive(false);
                toyLokomotive.SetActive(false);
            }
            else if (PlayerPrefs.GetString("lokomotive") == "hybrid")
            {
                classicLokomotive.SetActive(false);
                hybridLokomotive.SetActive(true);
                exclusiveLokomotive.SetActive(false);
                capsuleLokomotive.SetActive(false);
                kf2500Lokomotive.SetActive(false);
                tramLokomotive.SetActive(false);
                tankLokomotive.SetActive(false);
                spaceLokomotive.SetActive(false);
                toyLokomotive.SetActive(false);
            }
            else if (PlayerPrefs.GetString("lokomotive") == "exclusive")
            {
                classicLokomotive.SetActive(false);
                hybridLokomotive.SetActive(false);
                exclusiveLokomotive.SetActive(true);
                capsuleLokomotive.SetActive(false);
                kf2500Lokomotive.SetActive(false);
                tramLokomotive.SetActive(false);
                tankLokomotive.SetActive(false);
                spaceLokomotive.SetActive(false);
                toyLokomotive.SetActive(false);
            }
            else if (PlayerPrefs.GetString("lokomotive") == "capsule")
            {
                classicLokomotive.SetActive(false);
                hybridLokomotive.SetActive(false);
                exclusiveLokomotive.SetActive(false);
                capsuleLokomotive.SetActive(true);
                kf2500Lokomotive.SetActive(false);
                tramLokomotive.SetActive(false);
                tankLokomotive.SetActive(false);
                spaceLokomotive.SetActive(false);
                toyLokomotive.SetActive(false);
            }
            else if (PlayerPrefs.GetString("lokomotive") == "kf2500")
            {
                classicLokomotive.SetActive(false);
                hybridLokomotive.SetActive(false);
                exclusiveLokomotive.SetActive(false);
                capsuleLokomotive.SetActive(false);
                kf2500Lokomotive.SetActive(true);
                tramLokomotive.SetActive(false);
                tankLokomotive.SetActive(false);
                spaceLokomotive.SetActive(false);
                toyLokomotive.SetActive(false);
            }
            else if (PlayerPrefs.GetString("lokomotive") == "tram")
            {
                classicLokomotive.SetActive(false);
                hybridLokomotive.SetActive(false);
                exclusiveLokomotive.SetActive(false);
                capsuleLokomotive.SetActive(false);
                kf2500Lokomotive.SetActive(false);
                tramLokomotive.SetActive(true);
                tankLokomotive.SetActive(false);
                spaceLokomotive.SetActive(false);
                toyLokomotive.SetActive(false);
            }
            else if (PlayerPrefs.GetString("lokomotive") == "tank")
            {
                classicLokomotive.SetActive(false);
                hybridLokomotive.SetActive(false);
                exclusiveLokomotive.SetActive(false);
                capsuleLokomotive.SetActive(false);
                kf2500Lokomotive.SetActive(false);
                tramLokomotive.SetActive(false);
                tankLokomotive.SetActive(true);
                spaceLokomotive.SetActive(false);
                toyLokomotive.SetActive(false);
            }
            else if (PlayerPrefs.GetString("lokomotive") == "space")
            {
                classicLokomotive.SetActive(false);
                hybridLokomotive.SetActive(false);
                exclusiveLokomotive.SetActive(false);
                capsuleLokomotive.SetActive(false);
                kf2500Lokomotive.SetActive(false);
                tramLokomotive.SetActive(false);
                tankLokomotive.SetActive(false);
                spaceLokomotive.SetActive(true);
                toyLokomotive.SetActive(false);
            }
            else if (PlayerPrefs.GetString("lokomotive") == "toy")
            {
                classicLokomotive.SetActive(false);
                hybridLokomotive.SetActive(false);
                exclusiveLokomotive.SetActive(false);
                capsuleLokomotive.SetActive(false);
                kf2500Lokomotive.SetActive(false);
                tramLokomotive.SetActive(false);
                tankLokomotive.SetActive(false);
                spaceLokomotive.SetActive(false);
                toyLokomotive.SetActive(true);
            }

            if (PlayerPrefs.GetString("carriage") == "classic")
            {
                classicCarriage.SetActive(true);
                passengerCarriage.SetActive(false);
                coalCarriage.SetActive(false);
                containerCarriage.SetActive(false);
                spaceCarriage.SetActive(false);
                tramCarriage.SetActive(false);
                toyCarriage.SetActive(false);
            }
            else if (PlayerPrefs.GetString("carriage") == "passenger")
            {
                classicCarriage.SetActive(false);
                passengerCarriage.SetActive(true);
                coalCarriage.SetActive(false);
                containerCarriage.SetActive(false);
                spaceCarriage.SetActive(false);
                tramCarriage.SetActive(false);
                toyCarriage.SetActive(false);
            }
            else if (PlayerPrefs.GetString("carriage") == "coal")
            {
                classicCarriage.SetActive(false);
                passengerCarriage.SetActive(false);
                coalCarriage.SetActive(true);
                containerCarriage.SetActive(false);
                spaceCarriage.SetActive(false);
                tramCarriage.SetActive(false);
                toyCarriage.SetActive(false);
            }
            else if (PlayerPrefs.GetString("carriage") == "container")
            {
                classicCarriage.SetActive(false);
                passengerCarriage.SetActive(false);
                coalCarriage.SetActive(false);
                containerCarriage.SetActive(true);
                spaceCarriage.SetActive(false);
                tramCarriage.SetActive(false);
                toyCarriage.SetActive(false);
            }
            else if (PlayerPrefs.GetString("carriage") == "space")
            {
                classicCarriage.SetActive(false);
                passengerCarriage.SetActive(false);
                coalCarriage.SetActive(false);
                containerCarriage.SetActive(false);
                spaceCarriage.SetActive(true);
                tramCarriage.SetActive(false);
                toyCarriage.SetActive(false);
            }
            else if (PlayerPrefs.GetString("carriage") == "tram")
            {
                classicCarriage.SetActive(false);
                passengerCarriage.SetActive(false);
                coalCarriage.SetActive(false);
                containerCarriage.SetActive(false);
                spaceCarriage.SetActive(false);
                tramCarriage.SetActive(true);
                toyCarriage.SetActive(false);
            }
            else if (PlayerPrefs.GetString("carriage") == "toy")
            {
                classicCarriage.SetActive(false);
                passengerCarriage.SetActive(false);
                coalCarriage.SetActive(false);
                containerCarriage.SetActive(false);
                spaceCarriage.SetActive(false);
                tramCarriage.SetActive(false);
                toyCarriage.SetActive(true);
            }
            kontrol = false;
        }
    }
    public void OyunaGit()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void Mods()
    {
        mods.SetActive(true);
        anaGiris.SetActive(false);
    }

    public void Upgrades()
    {
        upgrades.SetActive(true);
        anaGiris.SetActive(false);
    }

    public void Settings()
    {
        settings.SetActive(true);
        anaGiris.SetActive(false);
    }

    public void Store()
    {
        store.SetActive(true);
        anaGiris.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }



}
