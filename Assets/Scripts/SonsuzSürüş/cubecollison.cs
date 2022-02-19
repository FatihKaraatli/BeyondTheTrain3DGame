using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecollison : MonoBehaviour
{
    private GameObject OyunBittiCanvas;
    public bool carptı_mı = false;
    GameObject tren;
    void Start()
    {
        OyunBittiCanvas = GameObject.FindGameObjectWithTag("OyunBitti");
        //OyunBittiCanvas.GetComponent<Canvas>().enabled = false;
        tren = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CollisionDelay();
        }
    }

    public void CollisionDelay()
    {
        Time.timeScale = 0f;
        tren.GetComponent<Train>().enabled = false;
        OyunBittiCanvas.GetComponent<Canvas>().enabled = true;
        carptı_mı = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        PlayerPrefs.SetFloat("x2çarpımdeğeri", 1f);
        PlayerPrefs.SetFloat("x4çarpımdeğeri", 1f);
    }

}
