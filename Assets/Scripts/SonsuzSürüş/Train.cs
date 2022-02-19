using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Train : MonoBehaviour
{
    public Transform cam;

    public Pause pauseMenu;

    Rigidbody rig;

    public float speed = 30f;
    public float trainIncreaseSpeed = 50f;
    public float timeScale = 0.0001f;
    public bool increaseSpeed = true;

    public float turnSmoothTime = 1.0f;
    public float turnSmoothVelocity = 5f;

    public int yol = 0;
    public TextMeshProUGUI skor;
    public float x1;
    public float x2;

    float sag = 2;
    float sol = -2;
    float orta = 0;

    public bool sag_mı = false;
    public bool sol_mu = false;
    public bool orta_mı = false;
    public bool baslangıc = true;
    public bool sag_dan_orta_mı = false;
    public bool sol_dan_orta_mı = false;

    float lerpNumber = 10f;

    bool hareketEdebilir_mi = true;
    public Text a;
    public Text b;

    bool isSwiping;
    Vector2 startTouching;

    public void Start()
    {
        rig = GetComponent<Rigidbody>();
        if (PlayerPrefs.GetString("reklamizlendimi") == "true")
        {
            timeScale = PlayerPrefs.GetFloat("reklamhızı");
        }
        else
        {
            timeScale = 0.0001f;
        }
    }
    void Update()
    {   
        rig.AddForce(new Vector3(0 ,0f , 5f) * speed );
        if (rig.velocity.z > turnSmoothVelocity)
        {
            rig.velocity = new Vector3(0f ,0f , turnSmoothVelocity * 3);
        }

        StartCoroutine(IncreaseSpeed());

        transform.rotation = Quaternion.Euler(new Vector3(0f ,0f ,0f));
        cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);

        //Klavye Hareket
        if (yol == 0)
        {
            if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 1)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(sag, transform.position.y, transform.position.z) , Time.deltaTime * lerpNumber);
                cam.transform.position += new Vector3(orta, 0, 0);
                yol++;
                sag_mı = true;
                sol_mu = false;
                orta_mı = false;
                baslangıc = false;
                sol_dan_orta_mı = false;
                sag_dan_orta_mı = false;
            }

            if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -1)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(sol, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                cam.transform.position += new Vector3(orta, 0, 0);
                yol--;
                sag_mı = false;
                sol_mu = true;
                orta_mı = false;
                baslangıc = false;
                sol_dan_orta_mı = false;
                sag_dan_orta_mı = false;
            }
        }
        else if (yol == 1)
        {
            if (Input.GetKeyDown(KeyCode.A) && transform.position.x > 1f)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                yol--;
                sag_mı = false;
                sol_mu = false;
                orta_mı = true;
                baslangıc = false;
                sag_dan_orta_mı = true;
                sol_dan_orta_mı = false;
            }
        }
        else if (yol == -1)
        {
            if (Input.GetKeyDown(KeyCode.D) && transform.position.x < -1f)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                yol++;
                sag_mı = false;
                sol_mu = false;
                orta_mı = true;
                baslangıc = false;
                sol_dan_orta_mı = true;
                sag_dan_orta_mı = false;
            }
        }

        if (baslangıc)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
        }
        else if (sag_mı)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(sag, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
        }
        else if (sol_mu)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(sol, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
        }
        else if (orta_mı)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
        }

        //Mobil Kontrol
        /*
                Touch parmak = Input.GetTouch(0);
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    x1 = parmak.position.x;
                }
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    x2 = parmak.position.x;
                }
                if (yol == 0)
                {
                    if (x2 > x1 && transform.position.x < 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        transform.position = Vector3.Lerp(transform.position, new Vector3(sag, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                        cam.transform.position += new Vector3(orta, 0, 0);
                        yol++;
                        sag_mı = true;
                        sol_mu = false;
                        orta_mı = false;
                        baslangıc = false;
                    }

                    if (x2 < x1 && transform.position.x > -1 && Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        transform.position = Vector3.Lerp(transform.position, new Vector3(sol, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                        cam.transform.position += new Vector3(orta, 0, 0);
                        yol--;
                        sag_mı = false;
                        sol_mu = true;
                        orta_mı = false;
                        baslangıc = false;
                    }
                }
                else if (yol == 1)
                {
                    if (x2 < x1 && transform.position.x > -1 && Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                        cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                        yol--;
                        sag_mı = false;
                        sol_mu = false;
                        orta_mı = true;
                        baslangıc = false;
                    }
                }
                else if (yol == -1)
                {
                    if (x2 > x1 && transform.position.x < 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                        cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                        yol++;
                        sag_mı = false;
                        sol_mu = false;
                        orta_mı = true;
                        baslangıc = false;
                    }
                }

                if (baslangıc)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                    cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                }
                else if (sag_mı)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(sag, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                    cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                }
                else if (sol_mu)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(sol, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                    cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                }
                else if (orta_mı)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                    cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                }
                */

        if(Input.touchCount == 1)
        {
            if (isSwiping)
            {
                Vector2 diff = Input.GetTouch(0).position - startTouching;
                diff = new Vector2(diff.x / Screen.width , diff.y / Screen.width);
                if (diff.magnitude > 0.01f)
                {
                    if (yol == 0)
                    {
                        if (diff.x > 0 && transform.position.x < 1)
                        {
                            transform.position = Vector3.Lerp(transform.position, new Vector3(sag, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                            cam.transform.position += new Vector3(orta, 0, 0);
                            yol++;
                            sag_mı = true;
                            sol_mu = false;
                            orta_mı = false;
                            baslangıc = false;
                        }

                        if (diff.x < 0 && transform.position.x > -1)
                        {
                            transform.position = Vector3.Lerp(transform.position, new Vector3(sol, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                            cam.transform.position += new Vector3(orta, 0, 0);
                            yol--;
                            sag_mı = false;
                            sol_mu = true;
                            orta_mı = false;
                            baslangıc = false;
                        }
                    }
                    else if (yol == 1)
                    {
                        if (diff.x < 0 && transform.position.x > -1)
                        {
                            transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                            yol--;
                            sag_mı = false;
                            sol_mu = false;
                            orta_mı = true;
                            baslangıc = false;
                        }
                    }
                    else if (yol == -1)
                    {
                        if (diff.x > 0 && transform.position.x < 1)
                        {
                            transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
                            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
                            yol++;
                            sag_mı = false;
                            sol_mu = false;
                            orta_mı = true;
                            baslangıc = false;
                        }
                    }
                    isSwiping = false;
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startTouching = Input.GetTouch(0).position;
                isSwiping = true;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                isSwiping = false;
            }
        }




        

        if (baslangıc)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
        }
        else if (sag_mı)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(sag, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
        }
        else if (sol_mu)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(sol, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
        }
        else if (orta_mı)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(orta, transform.position.y, transform.position.z), Time.deltaTime * lerpNumber);
            cam.transform.position = new Vector3(orta, cam.transform.position.y, cam.transform.position.z);
        }


        /*if (x2 > x1 && transform.position.x < 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            transform.position += new Vector3(2f, 0f, 0f);
            cam.transform.position += new Vector3(-2f, 0, 0);
        }
        else if (x2 < x1 && transform.position.x > -1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            transform.position += new Vector3(-2f, 0f, 0f);
            cam.transform.position += new Vector3(2f, 0, 0);
        }*/

        //Mobil Hareket

        /*if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);
            if (yol == 0)
            {
                if (parmak.deltaPosition.x < 50f && transform.position.x < 1)
                {
                    transform.position = new Vector3(2f, transform.position.y, transform.position.z);
                    cam.transform.position += new Vector3(-2f, 0, 0);
                    if(yol == 0 && parmak.phase == TouchPhase.Ended)
                    {
                        yol++;
                    }
                }

                if (parmak.deltaPosition.x > 50f && transform.position.x > -1)
                {
                    transform.position = new Vector3(-2f, transform.position.y, transform.position.z);
                    cam.transform.position += new Vector3(2f, 0, 0);
                    if (yol == 0 && parmak.phase == TouchPhase.Ended)
                    {
                        yol--;
                    }
                }
            }
            else if (yol == 1)
            {
                if (parmak.deltaPosition.x < 50f && transform.position.x > -1)
                {
                    transform.position = new Vector3(0f, transform.position.y, transform.position.z);
                    cam.transform.position = new Vector3(0f, cam.transform.position.y, cam.transform.position.z);
                    if (yol == 1 && parmak.phase == TouchPhase.Ended)
                    {
                        yol--;
                    }
                }
            }
            else if (yol == -1)
            {
                if (parmak.deltaPosition.x > 50f && transform.position.x < 1)
                {
                    transform.position = new Vector3(0f, transform.position.y, transform.position.z);
                    cam.transform.position = new Vector3(0f, cam.transform.position.y, cam.transform.position.z);
                    if (yol == -1 && parmak.phase == TouchPhase.Ended)
                    {
                        yol++;
                    }
                }
            }
        }*/

        /*if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 1)
        {
            transform.position = new Vector3(2f, transform.position.y, transform.position.z);
            cam.transform.position += new Vector3(-2f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -1)
        {
            transform.position = new Vector3(-2f, transform.position.y, transform.position.z);
            cam.transform.position += new Vector3(2f, 0, 0);
        }*/

        /*if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);

            if (yol == 0)
            {
                if (parmak.deltaPosition.x < 50f && transform.position.x < 1)
                {
                    transform.position += new Vector3(2f, 0, 0);
                    cam.transform.position += new Vector3(-2f, 0, 0);
                    if (parmak.phase == TouchPhase.Ended)
                    {
                        yol++;
                    }
                }

                if (parmak.deltaPosition.x > 50f && transform.position.x > -1 )
                {
                    transform.position += new Vector3(-2f, 0, 0);
                    cam.transform.position += new Vector3(2f, 0, 0);
                    if (parmak.phase == TouchPhase.Ended)
                    {
                        yol--;
                    }
                }
            }
            else if (yol == 1)
            {
                if (parmak.deltaPosition.x > 50f && transform.position.x > -1)
                {
                    transform.position += new Vector3(-2f, 0, 0);
                    cam.transform.position += new Vector3(2f, 0, 0);
                    if (parmak.phase == TouchPhase.Ended)
                    {
                        yol--;
                    }
                }
            }
            else if (yol == -1)
            {
                if (parmak.deltaPosition.x < 50f && transform.position.x < 1)
                {
                    transform.position += new Vector3(2f, 0, 0);
                    cam.transform.position += new Vector3(-2f, 0, 0);
                    if (parmak.phase == TouchPhase.Ended)
                    {
                        yol++;
                    }
                }
            }*/

        /*if (parmak.deltaPosition.x < 50f && transform.position.x < 1 )
        {
            transform.position += new Vector3(2f, 0, 0);
            cam.transform.position += new Vector3(-2f, 0, 0);
        }

        if (parmak.deltaPosition.x > 50f && transform.position.x > -1 )
        {
            transform.position += new Vector3(-2f, 0, 0);
            cam.transform.position += new Vector3(2f, 0, 0);
        }*/
    }

    IEnumerator IncreaseSpeed()
    {
        if (increaseSpeed && !pauseMenu.pause)
        {
            if (Time.timeScale == 2f)
            {
                Time.timeScale = 2f;
            }
            else if (Time.timeScale < 2f)
            {
                Time.timeScale = 1 + timeScale;
                timeScale += 0.00005f;
                PlayerPrefs.SetFloat("reklamhızı" , timeScale);
                Debug.Log(Time.timeScale);
                increaseSpeed = false;
            }
        }
        yield return new WaitForSeconds(1f);
        
        increaseSpeed = true;
    }

}
