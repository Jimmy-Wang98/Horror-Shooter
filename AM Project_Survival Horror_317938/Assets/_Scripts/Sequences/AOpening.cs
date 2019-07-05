﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class AOpening : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    public GameObject BGM;

    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine (ScenePlayer ());
    }
    IEnumerator ScenePlayer() {
        yield return new WaitForSeconds (1.5f);
        FadeScreenIn.SetActive (false);
        TextBox.GetComponent<Text> ().text = "Aargh... My head hurts...";
        ThePlayer.GetComponent<Animation>().Play("StartUp");
        BGM.SetActive (true);
        yield return new WaitForSeconds (2);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }
}
