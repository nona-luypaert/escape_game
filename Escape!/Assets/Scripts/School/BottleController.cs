using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : MonoBehaviour
{
    private GameObject initialBackground, finalBackground, buttonNext, buttonKey, key;

    void Start()
    {
        initialBackground = GameObject.Find("school_3");
        finalBackground = GameObject.Find("school_3_done");
        finalBackground.SetActive(false);
        buttonNext = GameObject.Find("Button_next");
        buttonNext.SetActive(false);
        buttonKey = GameObject.Find("Button_key");
        buttonKey.SetActive(false);
        key = GameObject.Find("school_3_key");
        key.SetActive(false);
    }

    public void clickBottle() 
    {
        initialBackground.SetActive(false);
        finalBackground.SetActive(true);
        key.SetActive(true);
        buttonKey.SetActive(true);

    }

    public void clickKey() 
    {
        buttonNext.SetActive(true);
    }
}
