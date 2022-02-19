using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sifirlama : MonoBehaviour
{

    public void Sıfırla()
    {
        PlayerPrefs.DeleteKey("skor");
        PlayerPrefs.DeleteAll();
    }

    public void Hile()
    {
        PlayerPrefs.SetFloat("ticket", (int)(PlayerPrefs.GetFloat("ticket") + 500000));
    }

    public void Back()
    {
        SceneManager.LoadScene("AnaGiris");
    }

    
}
