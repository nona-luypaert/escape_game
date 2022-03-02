using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TVController : MonoBehaviour
{
    [SerializeField]
    Text code;
    string codeString = "";
    private GameObject key, found_key, buttonNext;
    private Button buttonBook;
    private Button button_1;
    private Button button_2;
    private Button button_3;
    private Button button_4;
    private Button button_5;
    private Button button_6;
    private Button button_7;
    private Button button_8;
    private Button button_9;

    void Start()
    {
        buttonNext = GameObject.Find("Button_next");
        buttonNext.SetActive(false);
        buttonBook = GameObject.Find("Button_book").GetComponent<Button>();
        buttonBook.enabled = true;
        button_1 = GameObject.Find("Button_1").GetComponent<Button>();
        button_2 = GameObject.Find("Button_2").GetComponent<Button>();
        button_3 = GameObject.Find("Button_3").GetComponent<Button>();
        button_4 = GameObject.Find("Button_4").GetComponent<Button>();
        button_5 = GameObject.Find("Button_5").GetComponent<Button>();
        button_6 = GameObject.Find("Button_6").GetComponent<Button>();
        button_7 = GameObject.Find("Button_7").GetComponent<Button>();
        button_8 = GameObject.Find("Button_8").GetComponent<Button>();
        button_9 = GameObject.Find("Button_9").GetComponent<Button>();
        button_1.enabled = true;
        button_2.enabled = true;
        button_3.enabled = true;
        button_4.enabled = true;
        button_5.enabled = true;
        button_6.enabled = true;
        button_7.enabled = true;
        button_8.enabled = true;
        button_9.enabled = true;
    }

    void Update()
    {
        code.text = codeString;
        if (codeString == "1542")
        {
            buttonNext.SetActive(true);
            buttonBook.enabled = false;
            button_1.enabled = false;
            button_2.enabled = false;
            button_3.enabled = false;
            button_4.enabled = false;
            button_5.enabled = false;
            button_6.enabled = false;
            button_7.enabled = false;
            button_8.enabled = false;
            button_9.enabled = false;
        }
        if (codeString.Length >= 4)
        {
            codeString = "";
        }
    }

    public void clickNumber(string number)
    {
        codeString += number;
    }
}