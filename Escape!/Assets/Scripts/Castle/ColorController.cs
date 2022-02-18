using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    private string currentColor;
    private GameObject blue_button, blue_button_solved;
    private GameObject purple_button, purple_button_solved;
    private GameObject green_button, green_button_solved;
    private GameObject yellow_button, yellow_button_solved;
    private GameObject red_button, red_button_solved;
    private bool blue, purple, green, red, yellow;
    private GameObject next, back;

    void Start()
    {
        currentColor = "";
        blue_button = GameObject.Find("Mirror_blue");
        blue_button_solved = GameObject.Find("Square_blue");
        blue_button_solved.SetActive(false);
        green_button = GameObject.Find("Mirror_green");
        green_button_solved = GameObject.Find("Square_green");
        green_button_solved.SetActive(false);
        purple_button = GameObject.Find("Mirror_purple");
        purple_button_solved = GameObject.Find("Square_purple");
        purple_button_solved.SetActive(false);
        red_button = GameObject.Find("Mirror_red");
        red_button_solved = GameObject.Find("Square_red");
        red_button_solved.SetActive(false);
        yellow_button = GameObject.Find("Mirror_yellow");
        yellow_button_solved = GameObject.Find("Square_yellow");
        yellow_button_solved.SetActive(false);
        next = GameObject.Find("Button_next");
        next.SetActive(false);
        back = GameObject.Find("Button_back");
        blue = false;
        purple = false;
        green = false;
        red = false;
        yellow = false;
    }

    void Update()
    {
        if (blue)
        {
            blue_button_solved.SetActive(true);
            blue_button.SetActive(false);
        }
        if (purple)
        {
            purple_button_solved.SetActive(true);
            purple_button.SetActive(false);   
        }
        if (green)
        {
            green_button_solved.SetActive(true);
            green_button.SetActive(false);    
        }
        if (red)
        {
            red_button_solved.SetActive(true);
            red_button.SetActive(false);    
        }
        if (yellow) {
            yellow_button_solved.SetActive(true);
            yellow_button.SetActive(false);     
        }

        if (blue_button_solved.activeSelf && purple_button_solved.activeSelf && yellow_button_solved.activeSelf && red_button_solved.activeSelf && green_button_solved.activeSelf)
        {
            next.SetActive(true);
            back.SetActive(false);
        }
    }

    public void SetCurrentColor(string color) 
    {
        currentColor = color;
    }

    public void SetColorOnButton(string buttonColor) 
    {
        switch (buttonColor) 
        {
            case "blue": 
                if (buttonColor.Equals(currentColor)) 
                {
                    blue = true;
                }
                break;
            case "purple": 
                if (buttonColor.Equals(currentColor)) 
                {
                    purple = true;
                }              
                break;
            case "green": 
                if (buttonColor.Equals(currentColor)) 
                {
                    green = true;
                }             
                break;
            case "red": 
                if (buttonColor.Equals(currentColor)) 
                {
                    red = true;
                }             
                break;
            case "yellow": 
                if (buttonColor.Equals(currentColor)) 
                {
                    yellow = true;
                }               
                break;
        }
    }
}
