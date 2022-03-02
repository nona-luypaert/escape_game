using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoveController : MonoBehaviour
{
    public GameObject stove1, stove2, stove3, stove4;
    public Button button1, button2, button3, button4; 
    private int click1, click2, click3, click4;
    private GameObject button;   

    // Start is called before the first frame update
    void Start()
    {
        button1.enabled = true;
        button2.enabled = true;
        button3.enabled = true;
        button4.enabled = true;
        click1 = 0;
        click2 = 0;
        click3 = 0;
        click4 = 0;
        button = GameObject.Find("Button_next");
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (click1 == 6)
        {
            button1.enabled = false;
        }
        if (click2 == 2)
        {
            button2.enabled = false;
        }
        if (click3 == 4)
        {
            button3.enabled = false;
        }
        if (click4 == 2)
        {
            button4.enabled = false;
        }  

        if (click1 == 6 && click2 == 2 && click3 == 4 && click4 == 2)
        {
            button.SetActive(true);
        }                      
    }

    public void Rotate1() 
    {
        stove1.transform.Rotate(0.0f,0.0f,-45.0f);
        click1++;
    }
    
    public void Rotate2() 
    {
        stove2.transform.Rotate(0.0f,0.0f,-45.0f);
        click2++;
    }

    public void Rotate3() 
    {
        stove3.transform.Rotate(0.0f,0.0f,-45.0f);
        click3++;
    }

    public void Rotate4() 
    {
        stove4.transform.Rotate(0.0f,0.0f,-45.0f);
        click4++;
    }
}
