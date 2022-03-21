using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject fireFlash;
    public AudioSource gunFire;
    public bool isFiring = false;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FiringHandGun());
            }  
        }   
    }

    IEnumerator FiringHandGun()
    {
        isFiring = true;
        theGun.GetComponent<Animator>().Play("PistolFire");
        fireFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);
        fireFlash.SetActive(false);
        yield return new WaitForSeconds(0.45f);
        isFiring=false;
        theGun.GetComponent<Animator>().Play("New State");
    }
}
