using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LomokotiveChoose : MonoBehaviour
{
    public GameObject classicLokomotive;
    public GameObject hybridLokomotive;
    public GameObject exclusiveLokomotive;
    public GameObject capsuleLokomotive;
    public GameObject kf2500Lokomotive;
    public GameObject tramLokomotive;
    public GameObject tankLokomotive;
    public GameObject spaceLokomotive;
    public GameObject toyLokomotive;

    void Start()
    {
        if (PlayerPrefs.GetString("lokomotive") != "classic" && PlayerPrefs.GetString("lokomotive") != "hybrid" && PlayerPrefs.GetString("lokomotive") != "exclusive" && PlayerPrefs.GetString("lokomotive") != "capsule" && PlayerPrefs.GetString("lokomotive") != "kf2500" && PlayerPrefs.GetString("lokomotive") != "tram" && PlayerPrefs.GetString("lokomotive") != "tank" && PlayerPrefs.GetString("lokomotive") != "space" && PlayerPrefs.GetString("lokomotive") != "toy")
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
        else if (PlayerPrefs.GetString("lokomotive") == "classic")
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

    }

}
