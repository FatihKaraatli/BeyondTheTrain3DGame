using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenTicket : MonoBehaviour
{
    float speed = 3;
    public GameObject myself;

    public float yakınKameraBonus = 1f;
    public float geceBonus = 1f;
    public float dustBonus = 1f;
    public float x2Bonus = 1f;
    public float x4Bonus = 1f;


    void Start()
    {
        x4Bonus = 1f;
        x2Bonus = 1f;
    }

    void Update()
    {
        myself.transform.Rotate(new Vector3(0f, -15f, 0f) * Time.deltaTime * speed);

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

        if (PlayerPrefs.GetString("x2") == "true")
        {
            PlayerPrefs.SetFloat("x2çarpımdeğeri", 2f);
        }
        else if (PlayerPrefs.GetString("x2") == "false")
        {
            PlayerPrefs.SetFloat("x2çarpımdeğeri", 1f);
        }

        if (PlayerPrefs.GetString("x4") == "true")
        {
            PlayerPrefs.SetFloat("x4çarpımdeğeri", 4f);
        }
        else if (PlayerPrefs.GetString("x4") == "false")
        {
            PlayerPrefs.SetFloat("x4çarpımdeğeri", 1f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(myself);
            PlayerPrefs.SetFloat("ekranticket", PlayerPrefs.GetFloat("ekranticket") + 10 * yakınKameraBonus * geceBonus * dustBonus * PlayerPrefs.GetFloat("x4çarpımdeğeri") * PlayerPrefs.GetFloat("x2çarpımdeğeri"));
            PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") + 10 * yakınKameraBonus * geceBonus * dustBonus * PlayerPrefs.GetFloat("x4çarpımdeğeri") * PlayerPrefs.GetFloat("x2çarpımdeğeri"));
        }
    }
}
