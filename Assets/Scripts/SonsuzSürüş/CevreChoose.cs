using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CevreChoose : MonoBehaviour
{
    public GameObject forestEnvironment;
    public GameObject bridgeEnvironment;
    public GameObject desertEnvironment;
    public GameObject graveyardEnvironment;
    public GameObject cityEnvironment;
    public GameObject toycityEnvironment;

    void Start()
    {
        if (PlayerPrefs.GetString("environment") != "forest" && PlayerPrefs.GetString("environment") != "bridge" && PlayerPrefs.GetString("environment") != "desert" && PlayerPrefs.GetString("environment") != "graveyard" && PlayerPrefs.GetString("environment") != "city" && PlayerPrefs.GetString("environment") != "toycity")
        {
            forestEnvironment.SetActive(true);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toycityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "forest")
        {
            forestEnvironment.SetActive(true);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toycityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "bridge")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(true);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toycityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "desert")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(true);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toycityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "graveyard")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(true);
            cityEnvironment.SetActive(false);
            toycityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "city")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(true);
            toycityEnvironment.SetActive(false);
        }
        else if (PlayerPrefs.GetString("environment") == "toycity")
        {
            forestEnvironment.SetActive(false);
            bridgeEnvironment.SetActive(false);
            desertEnvironment.SetActive(false);
            graveyardEnvironment.SetActive(false);
            cityEnvironment.SetActive(false);
            toycityEnvironment.SetActive(true);
        }

    }
}
