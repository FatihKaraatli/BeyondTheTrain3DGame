using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X4Ses : MonoBehaviour
{
    AudioSource coinPickupSource;
    public AudioClip clip;
    void Start()
    {
        coinPickupSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "x4")
        {
            coinPickupSource.PlayOneShot(clip);
        }
    }
}
