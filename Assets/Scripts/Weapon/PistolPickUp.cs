using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PistolPickUp : MonoBehaviour
{
    public GameObject realPistol;
    public GameObject fakePistol;
    public AudioSource pistolPickUpSound;
    public GameObject pickUpDisplay;

    private void OnTriggerEnter(Collider other)
    {
        realPistol.SetActive(true);
        fakePistol.SetActive(false);
        pistolPickUpSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "Hand Gun";
        pickUpDisplay.SetActive(true);
    }
}
