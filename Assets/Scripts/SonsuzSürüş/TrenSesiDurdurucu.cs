using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrenSesiDurdurucu : MonoBehaviour
{
    public AudioSource trenSesi;

    void Update()
    {
        if (Time.timeScale == 0)
        {
            trenSesi.Pause();
        }
    }
}
