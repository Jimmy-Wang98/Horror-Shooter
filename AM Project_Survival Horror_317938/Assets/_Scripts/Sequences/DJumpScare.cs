using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJumpScare : MonoBehaviour
{
    public GameObject TheZombie1;
    public GameObject TheZombie2;
    public GameObject TheZombie3;
    public AudioSource ZombieSound;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheZombie1.SetActive(true);
        TheZombie2.SetActive(true);
        TheZombie3.SetActive(true);
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.1f);
        ZombieSound.Play();
    }
}
