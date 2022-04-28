using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PistolAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource ammoPickUpSound;
    public GameObject pickUpDisplay;

    private void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false);
        ammoPickUpSound.Play();
        GlobalAmmo.pistolAmmo += 10;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "Clip of bullet";
        pickUpDisplay.SetActive(true);
    }
}
