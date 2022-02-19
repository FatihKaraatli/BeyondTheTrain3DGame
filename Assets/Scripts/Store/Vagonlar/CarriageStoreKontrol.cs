using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarriageStoreKontrol : MonoBehaviour
{
    public GameObject store;
    public GameObject carriageStore;

    public GameObject classicCarriage;
    public GameObject classicCarriageCanvas;
    public GameObject classicSec;

    public GameObject passengerCarriage;
    public GameObject passengerCarriageCanvas;
    public GameObject passengerKilitAc;
    public GameObject passengerSec;
    public GameObject passengerKilit;
    public GameObject passengerUcret;
    public TextMeshProUGUI passengerUcretText;
    public bool passengerAlınabilir_mi = false;

    public GameObject coalCarriage;
    public GameObject coalCarriageCanvas;
    public GameObject coalKilitAc;
    public GameObject coalSec;
    public GameObject coalKilit;
    public GameObject coalUcret;
    public TextMeshProUGUI coalUcretText;
    public bool coalAlınabilir_mi = false;

    public GameObject containerCarriage;
    public GameObject containerCarriageCanvas;
    public GameObject containerKilitAc;
    public GameObject containerSec;
    public GameObject containerKilit;
    public GameObject containerUcret;
    public TextMeshProUGUI containerUcretText;
    public bool containerAlınabilir_mi = false;

    public GameObject spaceCarriage;
    public GameObject spaceCarriageCanvas;
    public GameObject spaceKilitAc;
    public GameObject spaceSec;
    public GameObject spaceKilit;
    public GameObject spaceUcret;
    public TextMeshProUGUI spaceUcretText;
    public bool spaceAlınabilir_mi = false;

    public GameObject tramCarriage;
    public GameObject tramCarriageCanvas;
    public GameObject tramKilitAc;
    public GameObject tramSec;
    public GameObject tramKilit;
    public GameObject tramUcret;
    public TextMeshProUGUI tramUcretText;
    public bool tramAlınabilir_mi = false;

    public GameObject toyCarriage;
    public GameObject toyCarriageCanvas;
    public GameObject toyKilitAc;
    public GameObject toySec;
    public GameObject toyKilit;
    public GameObject toyUcret;
    public TextMeshProUGUI toyUcretText;
    public bool toyAlınabilir_mi = false;

    int count = 0;
    public TextMeshProUGUI skor;

    public GameObject classicToggle;
    public GameObject passengerToggle;
    public GameObject coalToggle;
    public GameObject containerToggle;
    public GameObject tramToggle;
    public GameObject spaceToggle;
    public GameObject toyToggle;

    void Start()
    {
        if (PlayerPrefs.GetString("carriage") != "classic" && PlayerPrefs.GetString("carriage") != "passenger" && PlayerPrefs.GetString("carriage") != "coal" && PlayerPrefs.GetString("carriage") != "container" && PlayerPrefs.GetString("carriage") != "space" && PlayerPrefs.GetString("carriage") != "tram" && PlayerPrefs.GetString("carriage") != "toy")
        {
            PlayerPrefs.SetString("carriage", "classic");
        }

        if (PlayerPrefs.GetString("carriage") == "classic")
        {
            count = 0;
        }
        else if (PlayerPrefs.GetString("carriage") == "passenger")
        {
            count = 1;
        }
        else if (PlayerPrefs.GetString("carriage") == "coal")
        {
            count = 2;
        }
        else if (PlayerPrefs.GetString("carriage") == "container")
        {
            count = 3;
        }
        else if (PlayerPrefs.GetString("carriage") == "space")
        {
            count = 4;
        }
        else if (PlayerPrefs.GetString("carriage") == "tram")
        {
            count = 5;
        }
        else if (PlayerPrefs.GetString("carriage") == "toy")
        {
            count = 6;
        }
    }

    public void Update()
    {
        skor.text = "" + PlayerPrefs.GetFloat("ticket");

        ToggleChoose();

        if (count == 0)
        {
            classicCarriage.SetActive(true);
            classicCarriageCanvas.SetActive(true);
            classicSec.SetActive(true);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false);
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == 1)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(true);
            passengerCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("passengerAlınabilir_mi") != "true")
            {
                passengerKilitAc.SetActive(true);
                passengerSec.SetActive(false);
                passengerKilit.SetActive(true);
                passengerUcret.SetActive(true);
                passengerUcretText.text = "PRICE:20.000";
            }
            else
            {
                passengerKilitAc.SetActive(false);
                passengerSec.SetActive(true);
                passengerKilit.SetActive(false);
                passengerUcret.SetActive(false);
                passengerUcretText.text = "";
            }

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false);
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";

        }
        else if (count == 2)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(true);
            coalCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("coalAlınabilir_mi") != "true")
            {
                coalKilitAc.SetActive(true);
                coalSec.SetActive(false);
                coalKilit.SetActive(true);
                coalUcret.SetActive(true);
                coalUcretText.text = "PRICE:40.000";
            }
            else
            {
                coalKilitAc.SetActive(false);
                coalSec.SetActive(true);
                coalKilit.SetActive(false);
                coalUcret.SetActive(false);
                coalUcretText.text = "";
            }

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false);
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == 3)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(true);
            containerCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("containerAlınabilir_mi") != "true")
            {
                containerKilitAc.SetActive(true);
                containerSec.SetActive(false);
                containerKilit.SetActive(true);
                containerUcret.SetActive(true);
                containerUcretText.text = "PRICE:60.000";
            }
            else
            {
                containerKilitAc.SetActive(false);
                containerSec.SetActive(true);
                containerKilit.SetActive(false);
                containerUcret.SetActive(false);
                containerUcretText.text = "";
            }

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == 4)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false);
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(true);
            spaceCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("spaceWagonAlınabilir_mi") != "true")
            {
                spaceKilitAc.SetActive(true);
                spaceSec.SetActive(false);
                spaceKilit.SetActive(true);
                spaceUcret.SetActive(true);
                spaceUcretText.text = "PRICE:80.000";
            }
            else
            {
                spaceKilitAc.SetActive(false);
                spaceSec.SetActive(true);
                spaceKilit.SetActive(false);
                spaceUcret.SetActive(false);
                spaceUcretText.text = "";
            }

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == 5)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false);
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(true);
            tramCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("tramWagonAlınabilir_mi") != "true")
            {
                tramKilitAc.SetActive(true);
                tramSec.SetActive(false);
                tramKilit.SetActive(true);
                tramUcret.SetActive(true);
                tramUcretText.text = "PRICE:100.000";
            }
            else
            {
                tramKilitAc.SetActive(false);
                tramSec.SetActive(true);
                tramKilit.SetActive(false);
                tramUcret.SetActive(false);
                tramUcretText.text = "";
            }

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == 6)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false);
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(true);
            toyCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("toyWagonAlınabilir_mi") != "true")
            {
                toyKilitAc.SetActive(true);
                toySec.SetActive(false);
                toyKilit.SetActive(true);
                toyUcret.SetActive(true);
                toyUcretText.text = "PRICE:120.000";
            }
            else
            {
                toyKilitAc.SetActive(false);
                toySec.SetActive(true);
                toyKilit.SetActive(false);
                toyUcret.SetActive(false);
                toyUcretText.text = "";
            }
        }
        else if (count == 7)
        {
            count = 0;
        }
        else if (count == -1)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false);
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(true);
            toyCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("toyWagonAlınabilir_mi") != "true")
            {
                toyKilitAc.SetActive(true);
                toySec.SetActive(false);
                toyKilit.SetActive(true);
                toyUcret.SetActive(true);
                toyUcretText.text = "PRICE:120.000";
            }
            else
            {
                toyKilitAc.SetActive(false);
                toySec.SetActive(true);
                toyKilit.SetActive(false);
                toyUcret.SetActive(false);
                toyUcretText.text = "";
            }
        }
        else if (count == -2)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false); ;
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(true);
            tramCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("tramWagonAlınabilir_mi") != "true")
            {
                tramKilitAc.SetActive(true);
                tramSec.SetActive(false);
                tramKilit.SetActive(true);
                tramUcret.SetActive(true);
                tramUcretText.text = "PRICE:100.000";
            }
            else
            {
                tramKilitAc.SetActive(false);
                tramSec.SetActive(true);
                tramKilit.SetActive(false);
                tramUcret.SetActive(false);
                tramUcretText.text = "";
            }

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == -3)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false); ;
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(true);
            spaceCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("spaceWagonAlınabilir_mi") != "true")
            {
                spaceKilitAc.SetActive(true);
                spaceSec.SetActive(false);
                spaceKilit.SetActive(true);
                spaceUcret.SetActive(true);
                spaceUcretText.text = "PRICE:80.000";
            }
            else
            {
                spaceKilitAc.SetActive(false);
                spaceSec.SetActive(true);
                spaceKilit.SetActive(false);
                spaceUcret.SetActive(false);
                spaceUcretText.text = "";
            }

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";

        }
        else if (count == -4)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(true);
            containerCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("containerAlınabilir_mi") != "true")
            {
                containerKilitAc.SetActive(true);
                containerSec.SetActive(false);
                containerKilit.SetActive(true);
                containerUcret.SetActive(true);
                containerUcretText.text = "PRICE:60.000";
            }
            else
            {
                containerKilitAc.SetActive(false);
                containerSec.SetActive(true);
                containerKilit.SetActive(false);
                containerUcret.SetActive(false);
                containerUcretText.text = "";
            }

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == -5)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(false);
            passengerCarriageCanvas.SetActive(false);
            passengerKilitAc.SetActive(false);
            passengerSec.SetActive(false);
            passengerKilit.SetActive(false);
            passengerUcret.SetActive(false);
            passengerUcretText.text = "";

            coalCarriage.SetActive(true);
            coalCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("coalAlınabilir_mi") != "true")
            {
                coalKilitAc.SetActive(true);
                coalSec.SetActive(false);
                coalKilit.SetActive(true);
                coalUcret.SetActive(true);
                coalUcretText.text = "PRICE:40.000";
            }
            else
            {
                coalKilitAc.SetActive(false);
                coalSec.SetActive(true);
                coalKilit.SetActive(false);
                coalUcret.SetActive(false);
                coalUcretText.text = "";
            }

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false); ;
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == -6)
        {
            classicCarriage.SetActive(false);
            classicCarriageCanvas.SetActive(false);
            classicSec.SetActive(false);

            passengerCarriage.SetActive(true);
            passengerCarriageCanvas.SetActive(true);
            if (PlayerPrefs.GetString("passengerAlınabilir_mi") != "true")
            {
                passengerKilitAc.SetActive(true);
                passengerSec.SetActive(false);
                passengerKilit.SetActive(true);
                passengerUcret.SetActive(true);
                passengerUcretText.text = "PRICE:20.000";
            }
            else
            {
                passengerKilitAc.SetActive(false);
                passengerSec.SetActive(true);
                passengerKilit.SetActive(false);
                passengerUcret.SetActive(false);
                passengerUcretText.text = "";
            }

            coalCarriage.SetActive(false);
            coalCarriageCanvas.SetActive(false);
            coalKilitAc.SetActive(false);
            coalSec.SetActive(false);
            coalKilit.SetActive(false);
            coalUcret.SetActive(false);
            coalUcretText.text = "";

            containerCarriage.SetActive(false);
            containerCarriageCanvas.SetActive(false);
            containerKilitAc.SetActive(false);
            containerSec.SetActive(false);
            containerKilit.SetActive(false);
            containerUcret.SetActive(false);
            containerUcretText.text = "";

            spaceCarriage.SetActive(false);
            spaceCarriageCanvas.SetActive(false);
            spaceKilitAc.SetActive(false);
            spaceSec.SetActive(false);
            spaceKilit.SetActive(false);
            spaceUcret.SetActive(false);
            spaceUcretText.text = "";

            tramCarriage.SetActive(false);
            tramCarriageCanvas.SetActive(false);
            tramKilitAc.SetActive(false);
            tramSec.SetActive(false);
            tramKilit.SetActive(false);
            tramUcret.SetActive(false);
            tramUcretText.text = "";

            toyCarriage.SetActive(false);
            toyCarriageCanvas.SetActive(false);
            toyKilitAc.SetActive(false);
            toySec.SetActive(false);
            toyKilit.SetActive(false);
            toyUcret.SetActive(false);
            toyUcretText.text = "";
        }
        else if (count == -7)
        {
            count = 0;
        }
    }

    public void ClassicCarriageButton()
    {
        PlayerPrefs.SetString("carriage", "classic");

    }
    public void PassengerCarriageButton()
    {
        PlayerPrefs.SetString("carriage", "passenger");
    }

    public void CoalCarriageButton()
    {
        PlayerPrefs.SetString("carriage", "coal");
    }

    public void ContainerCarriageButton()
    {
        PlayerPrefs.SetString("carriage", "container");
    }
    public void SpaceCarriageButton()
    {
        PlayerPrefs.SetString("carriage", "space");
    }
    public void TramCarriageButton()
    {
        PlayerPrefs.SetString("carriage", "tram");
    }
    public void ToyCarriageButton()
    {
        PlayerPrefs.SetString("carriage", "toy");
    }

    public void PassengerCarriageBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 20000)
        {
            passengerAlınabilir_mi = true;
            PlayerPrefs.SetString("passengerAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 20000);
        }
    }
    public void CoalCarriageBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 100000)
        {
            coalAlınabilir_mi = true;
            PlayerPrefs.SetString("coalAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 100000);
        }
    }
    public void ContainerCarriageBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 120000)
        {
            containerAlınabilir_mi = true;
            PlayerPrefs.SetString("containerAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 120000);
        }
    }
    public void SpaceCarriageBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 180000)
        {
            spaceAlınabilir_mi = true;
            PlayerPrefs.SetString("spaceWagonAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 180000);
        }
    }
    public void TramCarriageBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 250000)
        {
            tramAlınabilir_mi = true;
            PlayerPrefs.SetString("tramWagonAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 250000);
        }
    }
    public void ToyCarriageBuy()
    {
        if (PlayerPrefs.GetFloat("ticket") >= 500000)
        {
            toyAlınabilir_mi = true;
            PlayerPrefs.SetString("toyWagonAlınabilir_mi", "true");
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") - 500000);
        }
    }


    public void ToggleChoose()
    {
        if (PlayerPrefs.GetString("carriage") != "classic" && PlayerPrefs.GetString("carriage") != "passenger" && PlayerPrefs.GetString("carriage") != "coal" && PlayerPrefs.GetString("carriage") != "container" && PlayerPrefs.GetString("carriage") != "space" && PlayerPrefs.GetString("carriage") != "tram" && PlayerPrefs.GetString("carriage") != "toy")
        {
            classicToggle.SetActive(true);
            passengerToggle.SetActive(false);
            coalToggle.SetActive(false);
            containerToggle.SetActive(false);
            tramToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }

        if (PlayerPrefs.GetString("carriage") == "classic")
        {
            classicToggle.SetActive(true);
            passengerToggle.SetActive(false);
            coalToggle.SetActive(false);
            containerToggle.SetActive(false);
            tramToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "passenger")
        {
            classicToggle.SetActive(false);
            passengerToggle.SetActive(true);
            coalToggle.SetActive(false);
            containerToggle.SetActive(false);
            tramToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "coal")
        {
            classicToggle.SetActive(false);
            passengerToggle.SetActive(false);
            coalToggle.SetActive(true);
            containerToggle.SetActive(false);
            tramToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "container")
        {
            classicToggle.SetActive(false);
            passengerToggle.SetActive(false);
            coalToggle.SetActive(false);
            containerToggle.SetActive(true);
            tramToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "space")
        {
            classicToggle.SetActive(false);
            passengerToggle.SetActive(false);
            coalToggle.SetActive(false);
            containerToggle.SetActive(false);
            tramToggle.SetActive(false);
            spaceToggle.SetActive(true);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "tram")
        {
            classicToggle.SetActive(false);
            passengerToggle.SetActive(false);
            coalToggle.SetActive(false);
            containerToggle.SetActive(false);
            tramToggle.SetActive(true);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(false);
        }
        else if (PlayerPrefs.GetString("carriage") == "toy")
        {
            classicToggle.SetActive(false);
            passengerToggle.SetActive(false);
            coalToggle.SetActive(false);
            containerToggle.SetActive(false);
            tramToggle.SetActive(false);
            spaceToggle.SetActive(false);
            toyToggle.SetActive(true);
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
        carriageStore.SetActive(false);
        store.SetActive(true);
    }
}
