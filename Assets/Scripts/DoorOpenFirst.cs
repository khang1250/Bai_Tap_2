using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{
    public GameObject theDoor;
    public AudioSource doorFX;

    private void OnTriggerEnter(Collider other)
    {
        theDoor.GetComponent<Animator>().Play("DoorOpen");
        doorFX.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorClose");
        this.GetComponent<BoxCollider>().enabled = true;
    }

}
