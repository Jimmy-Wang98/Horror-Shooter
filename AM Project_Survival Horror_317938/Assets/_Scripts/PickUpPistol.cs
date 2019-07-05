using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPistol : MonoBehaviour
{

public float TheDistance;
public GameObject ActionDisplay;
public GameObject ActionText;
public GameObject FakePistol;
public GameObject RealPistol;
public GameObject GuideArrow;
public GameObject TheTrigger;
public GameObject TheJumpTrigger;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver () {
        if (TheDistance <= 2) {
            ActionText.GetComponent<Text>().text = "Pick up the pistol";
            ActionDisplay.SetActive (true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action")){
            if (TheDistance <= 2) {
                TheTrigger.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                FakePistol.SetActive(false);
                GuideArrow.SetActive(false);
                RealPistol.SetActive(true);
                TheJumpTrigger.SetActive(true);
            }
        }
    }
    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
