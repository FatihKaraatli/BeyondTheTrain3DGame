using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModSecici : MonoBehaviour
{
    public GameObject classicKamera;
    public GameObject hybridKamera;
    public GameObject exclusiveKamera;
    public GameObject capsuleKamera;
    public GameObject KF2500Kamera;
    public GameObject tramKamera;
    public GameObject tankKamera;
    public GameObject spaceKamera;
    public GameObject toyKamera;

    public Material gunduz;
    public Material gece;

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

    public GameObject dust;

    void Start()
    {
        if (PlayerPrefs.GetString("kameramod") == "uzakkamera")
        {
            classicKamera.SetActive(false);
            hybridKamera.SetActive(false);
            exclusiveKamera.SetActive(false);
            capsuleKamera.SetActive(false);
            KF2500Kamera.SetActive(false);
            tramKamera.SetActive(false);
            tankKamera.SetActive(false);
            spaceKamera.SetActive(false);
            toyKamera.SetActive(false);
        }
        else if (PlayerPrefs.GetString("kameramod") == "yakınkamera")
        {
            classicKamera.SetActive(true);
            hybridKamera.SetActive(true);
            exclusiveKamera.SetActive(true);
            capsuleKamera.SetActive(true);
            KF2500Kamera.SetActive(true);
            tramKamera.SetActive(true);
            tankKamera.SetActive(true);
            spaceKamera.SetActive(true);
            toyKamera.SetActive(true);
        }

        if (PlayerPrefs.GetString("gecemod") == "gece")
        {
            RenderSettings.skybox = gece;
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
        }
        else if (PlayerPrefs.GetString("gecemod") == "gunduz")
        {
            RenderSettings.skybox = gunduz;
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
        }

        if (PlayerPrefs.GetString("dust") == "dustaçık")
        {
            dust.SetActive(true);
        }
        else if (PlayerPrefs.GetString("dust") == "dustkapalı")
        {
            dust.SetActive(false);
        }
    }


}
