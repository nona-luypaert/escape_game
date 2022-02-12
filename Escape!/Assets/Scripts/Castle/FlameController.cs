using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlameController : MonoBehaviour
{
    private GameObject flame1;
    private GameObject flame2;
    private Button button, button_1, button_2;
    public bool left, right;

    void Start()
    {
        flame1 = GameObject.Find("castle_fire_1");
        flame2 = GameObject.Find("castle_fire_2");
        button = GameObject.Find("Button_door").GetComponent<Button>();
        button_1 = GameObject.Find("Button_1").GetComponent<Button>();
        button_2 = GameObject.Find("Button_2").GetComponent<Button>();
        button.enabled = false;
        left = false;
        right = false;
    }

    void Update()
    {
        if (left && right) 
        {
            button.enabled = true;
        }
    }

    public void Left() 
    {
        left = true;
        button_1.enabled = false;
    }

    public void Right () 
    {
        right = true;
        button_2.enabled = false;
    }
}
