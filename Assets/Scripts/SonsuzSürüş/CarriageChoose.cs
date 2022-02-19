using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriageChoose : MonoBehaviour
{
    public GameObject[] classicCarriage;
    public GameObject[] passengerCarriage;
    public GameObject[] coalCarriage;
    public GameObject[] containerCarriage;
    public GameObject[] spaceCarriage;
    public GameObject[] tramCarriage;
    public GameObject[] toyCarriage;

    void Start()
    {
        if (PlayerPrefs.GetString("carriage") != "classic" && PlayerPrefs.GetString("carriage") != "passenger" && PlayerPrefs.GetString("carriage") != "coal" && PlayerPrefs.GetString("carriage") != "container" && PlayerPrefs.GetString("carriage") != "space" && PlayerPrefs.GetString("carriage") != "tram" && PlayerPrefs.GetString("carriage") != "toy")
        {
            for (int i = 0; i< classicCarriage.Length;i++)
            {
                classicCarriage[i].SetActive(true);
            }
            for (int i = 0; i < passengerCarriage.Length; i++)
            {
                passengerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < coalCarriage.Length; i++)
            {
                coalCarriage[i].SetActive(false);
            }
            for (int i = 0; i < containerCarriage.Length; i++)
            {
                containerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < spaceCarriage.Length; i++)
            {
                spaceCarriage[i].SetActive(false);
            }
            for (int i = 0; i < tramCarriage.Length; i++)
            {
                tramCarriage[i].SetActive(false);
            }
            for (int i = 0; i < toyCarriage.Length; i++)
            {
                toyCarriage[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("carriage") == "classic")
        {
            for (int i = 0; i < classicCarriage.Length; i++)
            {
                classicCarriage[i].SetActive(true);
            }
            for (int i = 0; i < passengerCarriage.Length; i++)
            {
                passengerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < coalCarriage.Length; i++)
            {
                coalCarriage[i].SetActive(false);
            }
            for (int i = 0; i < containerCarriage.Length; i++)
            {
                containerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < spaceCarriage.Length; i++)
            {
                spaceCarriage[i].SetActive(false);
            }
            for (int i = 0; i < tramCarriage.Length; i++)
            {
                tramCarriage[i].SetActive(false);
            }
            for (int i = 0; i < toyCarriage.Length; i++)
            {
                toyCarriage[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("carriage") == "passenger")
        {
            for (int i = 0; i < classicCarriage.Length; i++)
            {
                classicCarriage[i].SetActive(false);
            }
            for (int i = 0; i < passengerCarriage.Length; i++)
            {
                passengerCarriage[i].SetActive(true);
            }
            for (int i = 0; i < coalCarriage.Length; i++)
            {
                coalCarriage[i].SetActive(false);
            }
            for (int i = 0; i < containerCarriage.Length; i++)
            {
                containerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < spaceCarriage.Length; i++)
            {
                spaceCarriage[i].SetActive(false);
            }
            for (int i = 0; i < tramCarriage.Length; i++)
            {
                tramCarriage[i].SetActive(false);
            }
            for (int i = 0; i < toyCarriage.Length; i++)
            {
                toyCarriage[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("carriage") == "coal")
        {
            for (int i = 0; i < classicCarriage.Length; i++)
            {
                classicCarriage[i].SetActive(false);
            }
            for (int i = 0; i < passengerCarriage.Length; i++)
            {
                passengerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < coalCarriage.Length; i++)
            {
                coalCarriage[i].SetActive(true);
            }
            for (int i = 0; i < containerCarriage.Length; i++)
            {
                containerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < spaceCarriage.Length; i++)
            {
                spaceCarriage[i].SetActive(false);
            }
            for (int i = 0; i < tramCarriage.Length; i++)
            {
                tramCarriage[i].SetActive(false);
            }
            for (int i = 0; i < toyCarriage.Length; i++)
            {
                toyCarriage[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("carriage") == "container")
        {
            for (int i = 0; i < classicCarriage.Length; i++)
            {
                classicCarriage[i].SetActive(false);
            }
            for (int i = 0; i < passengerCarriage.Length; i++)
            {
                passengerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < coalCarriage.Length; i++)
            {
                coalCarriage[i].SetActive(false);
            }
            for (int i = 0; i < containerCarriage.Length; i++)
            {
                containerCarriage[i].SetActive(true);
            }
            for (int i = 0; i < spaceCarriage.Length; i++)
            {
                spaceCarriage[i].SetActive(false);
            }
            for (int i = 0; i < tramCarriage.Length; i++)
            {
                tramCarriage[i].SetActive(false);
            }
            for (int i = 0; i < toyCarriage.Length; i++)
            {
                toyCarriage[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("carriage") == "space")
        {
            for (int i = 0; i < classicCarriage.Length; i++)
            {
                classicCarriage[i].SetActive(false);
            }
            for (int i = 0; i < passengerCarriage.Length; i++)
            {
                passengerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < coalCarriage.Length; i++)
            {
                coalCarriage[i].SetActive(false);
            }
            for (int i = 0; i < containerCarriage.Length; i++)
            {
                containerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < spaceCarriage.Length; i++)
            {
                spaceCarriage[i].SetActive(true);
            }
            for (int i = 0; i < tramCarriage.Length; i++)
            {
                tramCarriage[i].SetActive(false);
            }
            for (int i = 0; i < toyCarriage.Length; i++)
            {
                toyCarriage[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("carriage") == "tram")
        {
            for (int i = 0; i < classicCarriage.Length; i++)
            {
                classicCarriage[i].SetActive(false);
            }
            for (int i = 0; i < passengerCarriage.Length; i++)
            {
                passengerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < coalCarriage.Length; i++)
            {
                coalCarriage[i].SetActive(false);
            }
            for (int i = 0; i < containerCarriage.Length; i++)
            {
                containerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < spaceCarriage.Length; i++)
            {
                spaceCarriage[i].SetActive(false);
            }
            for (int i = 0; i < tramCarriage.Length; i++)
            {
                tramCarriage[i].SetActive(true);
            }
            for (int i = 0; i < toyCarriage.Length; i++)
            {
                toyCarriage[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("carriage") == "toy")
        {
            for (int i = 0; i < classicCarriage.Length; i++)
            {
                classicCarriage[i].SetActive(false);
            }
            for (int i = 0; i < passengerCarriage.Length; i++)
            {
                passengerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < coalCarriage.Length; i++)
            {
                coalCarriage[i].SetActive(false);
            }
            for (int i = 0; i < containerCarriage.Length; i++)
            {
                containerCarriage[i].SetActive(false);
            }
            for (int i = 0; i < spaceCarriage.Length; i++)
            {
                spaceCarriage[i].SetActive(false);
            }
            for (int i = 0; i < tramCarriage.Length; i++)
            {
                tramCarriage[i].SetActive(false);
            }
            for (int i = 0; i < toyCarriage.Length; i++)
            {
                toyCarriage[i].SetActive(true);
            }
        }

    }
}
