using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreController : MonoBehaviour
{
    public GameObject anaGiris;
    public GameObject store;
    public GameObject lokomotifStore;
    public GameObject environmentStore;
    public GameObject carriageStore;

    public void Lokomotif()
    {
        lokomotifStore.SetActive(true);
        store.SetActive(false);
        PlayerPrefs.SetString("kamera", "lokomotif");
    }

    public void Environment()
    {
        environmentStore.SetActive(true);
        store.SetActive(false);
    }
    public void Carriage()
    {
        carriageStore.SetActive(true);
        store.SetActive(false);
        PlayerPrefs.SetString("kamera", "carriage");
    }

    public void Menu()
    {
        anaGiris.SetActive(true);
        store.SetActive(false);
        PlayerPrefs.SetString("kamera", "lokomotif");
    }

}
