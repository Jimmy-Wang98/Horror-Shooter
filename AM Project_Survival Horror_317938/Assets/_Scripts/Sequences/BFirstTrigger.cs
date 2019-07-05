using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BFirstTrigger : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject TheMarker;
    public GameObject TheTrigger;

    void OnTriggerEnter() {
        StartCoroutine(WeaponScene ());
    }

    IEnumerator WeaponScene(){
        TextBox.GetComponent<Text> ().text = "Is that a weapon on the table?";
        yield return new WaitForSeconds (2.5f);
        TextBox.GetComponent<Text> ().text = "";
        TheMarker.SetActive (true);
        TheTrigger.SetActive(false);
    }
}