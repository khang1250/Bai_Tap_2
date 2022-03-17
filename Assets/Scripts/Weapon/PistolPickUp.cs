using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPickUp : MonoBehaviour
{
    public GameObject realPistol;
    public GameObject fakePistol;
    public AudioSource pistolPickUpSound;

    private void OnTriggerEnter(Collider other)
    {
        realPistol.SetActive(true);
        fakePistol.SetActive(false);
        pistolPickUpSound.Play();
    }
}
