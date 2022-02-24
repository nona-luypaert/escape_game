using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreboardController : MonoBehaviour
{
    public Text number_1, number_2, number_3, number_4;
    private string numberString_1, numberString_2, numberString_3, numberString_4;
    private GameObject button;
    private Button button_note, button_1, button_2, button_3, button_4;

    void Start()
    {
        button = GameObject.Find("Button_next");
        button.SetActive(false);
        numberString_1 = "";
        numberString_2 = "";
        numberString_3 = "";
        numberString_4 = "";
        button_note = GameObject.Find("Button_note").GetComponent<Button>();
        button_1 = GameObject.Find("Button_1").GetComponent<Button>();
        button_2 = GameObject.Find("Button_2").GetComponent<Button>();
        button_3 = GameObject.Find("Button_3").GetComponent<Button>();
        button_4 = GameObject.Find("Button_4").GetComponent<Button>();

    }

    void Update()
    {
        number_1.text = numberString_1;
        number_2.text = numberString_2;
        number_3.text = numberString_3;
        number_4.text = numberString_4;
        if (numberString_1 == "9" && numberString_2 == "1" && numberString_3 == "4" && numberString_4 == "8") 
        {
            button_note.enabled = false;
            button_1.enabled = false;
            button_2.enabled = false;
            button_3.enabled = false;
            button_4.enabled = false;
            button.SetActive(true);
        }
    }

    public void clickOne()
    {
        if (numberString_1 == "9")
        {
            numberString_1 = "0";
        } else 
        {
            int temp1 = 0;
            if (Int32.TryParse(numberString_1, out temp1)) 
            {
                temp1 += 1;
            }
            numberString_1 = temp1.ToString();
        }
    }

    public void clickTwo()
    {
        if (numberString_2 == "9")
        {
            numberString_2 = "0";
        } else 
        {
            int temp2 = 0;
            if (Int32.TryParse(numberString_2, out temp2)) 
            {
                temp2 += 1;
            }
            numberString_2 = temp2.ToString();        
        }
    }

        public void clickThree()
    {
        if (numberString_3 == "9")
        {
            numberString_3 = "0";
        } else 
        {
            int temp3 = 0;
            if (Int32.TryParse(numberString_3, out temp3)) 
            {
                temp3 += 1;
            }
            numberString_3 = temp3.ToString();        }
    }

        public void clickFour()
    {
        if (numberString_4 == "9")
        {
            numberString_4 = "0";
        } else 
        {
            int temp4 = 0;
            if (Int32.TryParse(numberString_4, out temp4)) 
            {
                temp4 += 1;
            }
            numberString_4 = temp4.ToString();        }
    }
}
