using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private GameObject next;
    private bool left, right;
    private Button buttonR, buttonL;

    void Start()
    {
        left = false;
        right = false;
        next = GameObject.Find("Button_next");
        next.SetActive(false);
        buttonL = GameObject.Find("Button_left").GetComponent<Button>();
        buttonL.enabled = true;
        buttonR = GameObject.Find("Button_right").GetComponent<Button>();
        buttonR.enabled = true;
    }

    void Update()
    {
        if (Input.touchCount > 1 && right && left)
        {
             next.SetActive(true);
            buttonR.enabled = false;
            buttonL.enabled = false;
        }
    }

    public void onPressL() {
        left = true;

    }

    public void onReleaseL() {
        left = false;

    }

    public void onPressR() {
        right = true;
    }

    public void onReleaseR() {
        right = false;
    }
}

