using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterController : MonoBehaviour
{
    public GameObject water, drain;
    public Button key;

    void Start()
    {
        water = GameObject.Find("house_water");
        drain = GameObject.Find("house_bath_plug");
        key = GameObject.Find("Button_key").GetComponent<Button>();
        key.enabled = false;
    }

    public void DrainWater()
    {
        water.SetActive(false);
        drain.SetActive(false);
        key.enabled = true;
    }
}
