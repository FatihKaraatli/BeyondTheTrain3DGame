using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Horn : MonoBehaviour
{
    public GameObject tren;
    public Train train;
    public Skor skor;
    Collider trenCollider;
    public Button hornButton;
    public Camera camera;
    //public AudioSource hornSound;

    public bool korna_mı = false;
    public bool transformYBir = false;

    public float clock = 0f;
    void Start()
    {
        clock = 0f;
        hornButton.image.fillAmount = 0f;
        trenCollider = tren.GetComponent<BoxCollider>();

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    
    void Update()
    {
        clock = clock + Time.deltaTime;

        if (!korna_mı)
        {
            hornButton.image.fillAmount = clock / 20f;
        }

        if ((int)clock == 20f)
        {
            ColorBlock colors = hornButton.colors;
            colors.normalColor = new Color32(255, 100, 100, 255);
            hornButton.colors = colors;
            korna_mı = true;
        }

        if (transformYBir)
        {
            tren.transform.position = new Vector3(tren.transform.position.x, 0.636f, tren.transform.position.z);
            tren.transform.rotation = Quaternion.Euler(0, 0f, 0);
            hornButton.image.fillAmount -= 0.2f * Time.deltaTime;
        }
    }

    public void HornButton()
    {
        if (korna_mı)
        {
            StartCoroutine(KornaBasıldı());
        }
    }

    IEnumerator KornaBasıldı()
    {
        //hornSound.Play();
        trenCollider.isTrigger = true;
        transformYBir = true;
        camera.fieldOfView = 80;
        Time.timeScale = 1;
        train.speed = 100;
        train.turnSmoothVelocity = 15;
        skor.hornDegiskeni = 300f;

        yield return new WaitForSeconds(5f);
        
        clock = 0f;
        hornButton.image.fillAmount = 0f;
        ColorBlock colors = hornButton.colors;
        colors.normalColor = Color.white;
        hornButton.colors = colors;
        korna_mı = false;
        trenCollider.isTrigger = false;
        transformYBir = false;
        camera.fieldOfView = 70f;
        train.speed = 30f;
        train.turnSmoothVelocity = 5f;
        skor.hornDegiskeni = 100f;
        Time.timeScale = 1;
        train.timeScale = 0.0001f;
    }
}
