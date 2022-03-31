using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource ammoPickUpSound;

    private void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false);
        ammoPickUpSound.Play();
        GlobalAmmo.pistolAmmo += 15;
    }
}
