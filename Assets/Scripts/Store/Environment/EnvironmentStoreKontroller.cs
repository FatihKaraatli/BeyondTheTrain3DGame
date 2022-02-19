using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnvironmentStoreKontroller : MonoBehaviour
{
    public GameObject store;
    public GameObject environmentStore;

    public GameObject forestEnvironment;
    public GameObject forestEnvironmentCanvas;
    public GameObject forestSec;

    public GameObject bridgeEnvironment;
    public GameObject bridgeEnvironmentCanvas;
    public GameObject bridgeKilitAc;
    public GameObject bridgeSec;
    public GameObject bridgeKilit;
    public GameObject bridgeUcret;
    public TextMeshProUGUI bridgeUcretText;
    public bool bridgeAlınabilir_mi = false;

    public GameObject desertEnvironment;
    public GameObject desertEnvironmentCanvas;
    public GameObject desertKilitAc;
    public GameObject desertSec;
    public GameObject desertKilit;
    public GameObject desertUcret;
    public TextMeshProUGUI desertUcretText;
    public bool desertAlınabilir_mi = false;

    public GameObject graveyardEnvironment;
    public GameObject graveyardEnvironmentCanvas;
    public GameObject graveyardKilitAc;
    public GameObject graveyardSec;
    public GameObject graveyardKilit;
    public GameObject graveyardUcret;
    public TextMeshProUGUI graveyardUcretText;
    public bool graveyardAlınabilir_mi = false;

    public GameObject cityEnvironment;
    public GameObject cityEnvironmentCanvas;
    public GameObject cityKilitAc;
    public GameObject citySec;
    public GameObject cityKilit;
    public GameObject cityUcret;
    public TextMeshProUGUI cityUcretText;
    public bool cityAlınabilir_mi = false;

    public GameObject toycityEnvironment;
    public GameObject toycityEnvironmentCanvas;
    public GameObject toycityKilitAc;
    public GameObject toycitySec;
    public GameObject toycityKilit;
    public GameObject toycityUcret;
    public TextMeshProUGUI toycityUcretText;
    public bool toycityAlınabilir_mi = false;

    int count = 0;
    public TextMeshProUGUI skor;

    public GameObject forestToggle;
    public GameObject bridgeToggle;
    public GameObject desertToggle;
    public GameObject graveyardToggle;
    public GameObject cityToggle;
    public GameObject toycityToggle;

    void Start()
    {
        if (PlayerPrefs.GetString("environment") != "forest" && PlayerPrefs.GetString("environment") != "bridge" && PlayerPrefs.GetString("environment") != "desert" && PlayerPrefs.GetString("environment") != "graveyard" && PlayerPrefs.GetString("environment") != "city" && PlayerPrefs.GetString("environment") != "toycity")
        {
            PlayerPrefs.SetString("environment", "forest");
        }

        if (PlayerPrefs.GetString("environment") == "forest")
        {
            count = 0;
        }
        else if (PlayerPrefs.GetString("environment") == "bridge")
        {
            count = 1;
        }
        else if (PlayerPrefs.GetString("environment") == "desert")
        {
            count = 2;
        }
        else if (PlayerPrefs.GetString("environment") == "graveyard")
        {
            count = 3;
        }
        else if (PlayerPrefs.GetString("environment") == "city")
        {
            count = 4;
        }
        else if (PlayerPrefs.GetString("environment") == "toycity")
        {
            count = 5;
        }
    }

    void Update()
    {
        skor.text = "" + PlayerPrefs.GetFloat("ticket");

        ToggleChoose();

        if (count == 0)
        {
            forestEnvironment.SetActive(true);
            forestEnvironmentCanvas.SetActive(true);
            forestSec.SetActive(true);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";

        }
        else if (count == 1)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(true);
            bridgeEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("bridgeAlınabilir_mi") != "true")
            {
                bridgeKilitAc.SetActive(true);
                bridgeSec.SetActive(false);
                bridgeKilit.SetActive(true);
                bridgeUcret.SetActive(true);
                bridgeUcretText.text = "PRICE:20.000";
            }
            else
            {
                bridgeKilitAc.SetActive(false);
                bridgeSec.SetActive(true);
                bridgeKilit.SetActive(false);
                bridgeUcret.SetActive(false);
                bridgeUcretText.text = "";
            }

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";


        }
        else if (count == 2)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(true);
            desertEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("desertAlınabilir_mi") != "true")
            {
                desertKilitAc.SetActive(true);
                desertSec.SetActive(false);
                desertKilit.SetActive(true);
                desertUcret.SetActive(true);
                desertUcretText.text = "PRICE:40.000";
            }
            else
            {
                desertKilitAc.SetActive(false);
                desertSec.SetActive(true);
                desertKilit.SetActive(false);
                desertUcret.SetActive(false);
                desertUcretText.text = "";
            }

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";
        }
        else if (count == 3)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(true);
            graveyardEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("graveyardAlınabilir_mi") != "true")
            {
                graveyardKilitAc.SetActive(true);
                graveyardSec.SetActive(false);
                graveyardKilit.SetActive(true);
                graveyardUcret.SetActive(true);
                graveyardUcretText.text = "PRICE:60.000";
            }
            else
            {
                graveyardKilitAc.SetActive(false);
                graveyardSec.SetActive(true);
                graveyardKilit.SetActive(false);
                graveyardUcret.SetActive(false);
                graveyardUcretText.text = "";
            }

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";
        }
        else if (count == 4)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(true);
            cityEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("cityAlınabilir_mi") != "true")
            {
                cityKilitAc.SetActive(true);
                citySec.SetActive(false);
                cityKilit.SetActive(true);
                cityUcret.SetActive(true);
                cityUcretText.text = "PRICE:80.000";
            }
            else
            {
                cityKilitAc.SetActive(false);
                citySec.SetActive(true);
                cityKilit.SetActive(false);
                cityUcret.SetActive(false);
                cityUcretText.text = "";
            }

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";
        }
        else if (count == 5)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(true);
            toycityEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("toycityAlınabilir_mi") != "true")
            {
                toycityKilitAc.SetActive(true);
                toycitySec.SetActive(false);
                toycityKilit.SetActive(true);
                toycityUcret.SetActive(true);
                toycityUcretText.text = "PRICE:100.000";
            }
            else
            {
                toycityKilitAc.SetActive(false);
                toycitySec.SetActive(true);
                toycityKilit.SetActive(false);
                toycityUcret.SetActive(false);
                toycityUcretText.text = "";
            }
        }
        else if (count == 6)
        {
            count = 0;
        }

        else if (count == -1)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(true);
            toycityEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("toycityAlınabilir_mi") != "true")
            {
                toycityKilitAc.SetActive(true);
                toycitySec.SetActive(false);
                toycityKilit.SetActive(true);
                toycityUcret.SetActive(true);
                toycityUcretText.text = "PRICE:100.000";
            }
            else
            {
                toycityKilitAc.SetActive(false);
                toycitySec.SetActive(true);
                toycityKilit.SetActive(false);
                toycityUcret.SetActive(false);
                toycityUcretText.text = "";
            }
        }
        else if (count == -2)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(true);
            cityEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("cityAlınabilir_mi") != "true")
            {
                cityKilitAc.SetActive(true);
                citySec.SetActive(false);
                cityKilit.SetActive(true);
                cityUcret.SetActive(true);
                cityUcretText.text = "PRICE:80.000";
            }
            else
            {
                cityKilitAc.SetActive(false);
                citySec.SetActive(true);
                cityKilit.SetActive(false);
                cityUcret.SetActive(false);
                cityUcretText.text = "";
            }

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";
        }
        else if (count == -3)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(true);
            graveyardEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("graveyardAlınabilir_mi") != "true")
            {
                graveyardKilitAc.SetActive(true);
                graveyardSec.SetActive(false);
                graveyardKilit.SetActive(true);
                graveyardUcret.SetActive(true);
                graveyardUcretText.text = "PRICE:60.000";
            }
            else
            {
                graveyardKilitAc.SetActive(false);
                graveyardSec.SetActive(true);
                graveyardKilit.SetActive(false);
                graveyardUcret.SetActive(false);
                graveyardUcretText.text = "";
            }

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";
        }
        else if (count == -4)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(false);
            bridgeEnvironmentCanvas.SetActive(false);
            bridgeKilitAc.SetActive(false);
            bridgeSec.SetActive(false);
            bridgeKilit.SetActive(false);
            bridgeUcret.SetActive(false);
            bridgeUcretText.text = "";

            desertEnvironment.SetActive(true);
            desertEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("desertAlınabilir_mi") != "true")
            {
                desertKilitAc.SetActive(true);
                desertSec.SetActive(false);
                desertKilit.SetActive(true);
                desertUcret.SetActive(true);
                desertUcretText.text = "PRICE:40.000";
            }
            else
            {
                desertKilitAc.SetActive(false);
                desertSec.SetActive(true);
                desertKilit.SetActive(false);
                desertUcret.SetActive(false);
                desertUcretText.text = "";
            }

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";
        }
        else if (count == -5)
        {
            forestEnvironment.SetActive(false);
            forestEnvironmentCanvas.SetActive(false);
            forestSec.SetActive(false);

            bridgeEnvironment.SetActive(true);
            bridgeEnvironmentCanvas.SetActive(true);
            if (PlayerPrefs.GetString("bridgeAlınabilir_mi") != "true")
            {
                bridgeKilitAc.SetActive(true);
                bridgeSec.SetActive(false);
                bridgeKilit.SetActive(true);
                bridgeUcret.SetActive(true);
                bridgeUcretText.text = "PRICE:20.000";
            }
            else
            {
                bridgeKilitAc.SetActive(false);
                bridgeSec.SetActive(true);
                bridgeKilit.SetActive(false);
                bridgeUcret.SetActive(false);
                bridgeUcretText.text = "";
            }

            desertEnvironment.SetActive(false);
            desertEnvironmentCanvas.SetActive(false);
            desertKilitAc.SetActive(false);
            desertSec.SetActive(false);
            desertKilit.SetActive(false);
            desertUcret.SetActive(false);
            desertUcretText.text = "";

            graveyardEnvironment.SetActive(false);
            graveyardEnvironmentCanvas.SetActive(false);
            graveyardKilitAc.SetActive(false);
            graveyardSec.SetActive(false);
            graveyardKilit.SetActive(false);
            graveyardUcret.SetActive(false);
            graveyardUcretText.text = "";

            cityEnvironment.SetActive(false);
            cityEnvironmentCanvas.SetActive(false);
            cityKilitAc.SetActive(false);
            citySec.SetActive(false);
            cityKilit.SetActive(false);
            cityUcret.SetActive(false);
            cityUcretText.text = "";

            toycityEnvironment.SetActive(false);
            toycityEnvironmentCanvas.SetActive(false);
            toycityKilitAc.SetActive(false);
            toycitySec.SetActive(false);
            toycityKilit.SetActive(false);
            toycityUcret.SetActive(false);
            toycityUcretText.text = "";
        }
        else if (count == -6)
        {
            count = 0;
        }

    }
    public void ForestEnvironmentButton()
    {
        PlayerPrefs.SetString("environment", "forest");
    }

    public void BridgeEnvironmentButton()
    {
        PlayerPrefs.SetString("environment", "bridge");
    }

    public void DesertEnvironmentButton()
    {
        PlayerPrefs.SetString("environment", "desert");
    }
    public void GraveyardEnvironmentButton()
    {
        PlayerPrefs.SetString("environment", "graveyard");
    }
    public void CityEnvironmentButton()
    {
        PlayerPrefs.SetString("environment", "city");
    }
    public void ToyCityEnvironmentButton()
    {
        PlayerPrefs.SetString("environment", "toycity");
    }


    public void BridgeEnvironmentBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 100000)
        {
            bridgeAlınabilir_mi = true;
            PlayerPrefs.SetString("bridgeAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 100000);
        }
    }
    public void DesertEnvironmentBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 200000)
        {
            desertAlınabilir_mi = true;
            PlayerPrefs.SetString("desertAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 200000);
        }
    }
    public void GraveyardEnvironmentBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 300000)
        {
            graveyardAlınabilir_mi = true;
            PlayerPrefs.SetString("graveyardAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 300000);
        }
    }
    public void CityEnvironmentBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 400000)
        {
            cityAlınabilir_mi = true;
            PlayerPrefs.SetString("cityAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 400000);
        }
    }
    public void ToyCityEnvironmentBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 1000000)
        {
            toycityAlınabilir_mi = true;
            PlayerPrefs.SetString("toycityAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 1000000);
        }
    }



    public void ToggleChoose()
    {
        if (PlayerPrefs.GetString("environment") != "forest" && PlayerPrefs.GetString("environment") != "bridge" && PlayerPrefs.GetString("environment") != "desert" && PlayerPrefs.GetString("environment") != "graveyard" && PlayerPrefs.GetString("environment") != "city" && PlayerPrefs.GetString("environment") != "toycity")
        {
            forestToggle.SetActive(true);
            bridgeToggle.SetActive(false);
            desertToggle.SetActive(false);
            graveyardToggle.SetActive(false);
            cityToggle.SetActive(false);
            toycityToggle.SetActive(false);
        }

        if (PlayerPrefs.GetString("environment") == "forest")
        {
            forestToggle.SetActive(true);
            bridgeToggle.SetActive(false);
            desertToggle.SetActive(false);
            graveyardToggle.SetActive(false);
            cityToggle.SetActive(false);
            toycityToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "bridge")
        {
            forestToggle.SetActive(false);
            bridgeToggle.SetActive(true);
            desertToggle.SetActive(false);
            graveyardToggle.SetActive(false);
            cityToggle.SetActive(false);
            toycityToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "desert")
        {
            forestToggle.SetActive(false);
            bridgeToggle.SetActive(false);
            desertToggle.SetActive(true);
            graveyardToggle.SetActive(false);
            cityToggle.SetActive(false);
            toycityToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "graveyard")
        {
            forestToggle.SetActive(false);
            bridgeToggle.SetActive(false);
            desertToggle.SetActive(false);
            graveyardToggle.SetActive(true);
            cityToggle.SetActive(false);
            toycityToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "city")
        {
            forestToggle.SetActive(false);
            bridgeToggle.SetActive(false);
            desertToggle.SetActive(false);
            graveyardToggle.SetActive(false);
            cityToggle.SetActive(true);
            toycityToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "toycity")
        {
            forestToggle.SetActive(false);
            bridgeToggle.SetActive(false);
            desertToggle.SetActive(false);
            graveyardToggle.SetActive(false);
            cityToggle.SetActive(false);
            toycityToggle.SetActive(true);
        }
    }


    public void RightButton()
    {
        count++;
    }

    public void LeftButton()
    {
        count--;
    }

    public void BackButton()
    {
        environmentStore.SetActive(false);
        store.SetActive(true);
    }

}
