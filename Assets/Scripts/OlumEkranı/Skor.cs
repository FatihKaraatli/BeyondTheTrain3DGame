using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public float clock = 0f;
    public float hornDegiskeni = 1f;
    public TextMeshProUGUI skor;
    public TextMeshProUGUI ekranSkor;

    public TextMeshProUGUI ticket;
    public TextMeshProUGUI ekranticket;

    float puan = 0f;
    float highScore = 0f;

    public float yakınKameraBonus = 1f;
    public float geceBonus = 1f;
    public float dustBonus = 1f;

    float skorToplam = 0f;
    float skorEkranToplam = 0f;

    void Start()
    {
        if (PlayerPrefs.GetString("reklamizlendimi") == "true")
        {
            clock = PlayerPrefs.GetFloat("reklamskor");
            //PlayerPrefs.SetString("reklamizlendimi", "false");
        }
        else
        {
            clock = 0f;
        }
        puan = PlayerPrefs.GetFloat("skor");
        PlayerPrefs.SetFloat("ekranticket", 0f);
    }
    
    void Update()
    {
        clock = clock + Time.deltaTime;

        if (PlayerPrefs.GetString("kameramod") == "yakınkamera")
        {
            yakınKameraBonus = 1.2f;
        }
        else if (PlayerPrefs.GetString("kameramod") == "uzakkamera")
        {
            yakınKameraBonus = 1.0f;
        }

        if (PlayerPrefs.GetString("gecemod") == "gece")
        {
            geceBonus = 1.5f;
        }
        else if (PlayerPrefs.GetString("gecemod") == "gunduz")
        {
            geceBonus = 1.0f;
        }

        if (PlayerPrefs.GetString("dust") == "dustaçık")
        {
            dustBonus = 2.0f;
        }
        else if (PlayerPrefs.GetString("dust") == "dustkapalı")
        {
            dustBonus = 1.0f;
        }


        skorToplam = clock * hornDegiskeni * yakınKameraBonus * geceBonus * dustBonus;
        skorEkranToplam = ((int)(clock * hornDegiskeni * yakınKameraBonus * geceBonus * dustBonus));

        skor.text = "" + skorToplam;
        ekranSkor.text = skorEkranToplam + "";
        //ekranSkor.text = Time.timeScale + "";
        ekranticket.text = "x" + PlayerPrefs.GetFloat("ekranticket");
        ticket.text = "x" + PlayerPrefs.GetFloat("ekranticket");
        PlayerPrefs.SetFloat("skor", puan + skorEkranToplam);
        PlayerPrefs.SetFloat("reklamskor", clock);
        highScore = skorEkranToplam;
        if (skorEkranToplam > PlayerPrefs.GetFloat("highScore"))
        {
            PlayerPrefs.SetFloat("highScore", skorToplam);
        }
        else
        {
            PlayerPrefs.SetFloat("highScore", (int)PlayerPrefs.GetFloat("highScore"));
        }
        


    }
}
