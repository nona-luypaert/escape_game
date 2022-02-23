using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeController : MonoBehaviour
{
    [SerializeField]
    Text code;
    string codeString = "";
    private GameObject key, found_key;


    void Start()
    {
        key = GameObject.Find("school_2_key");
        found_key = GameObject.Find("school_2_key_found");
        found_key.SetActive(false);
    }

    void Update()
    {
        code.text = codeString;
        if (codeString == "385")
        {
            key.SetActive(false);
            found_key.SetActive(true);
        }
        if (codeString.Length >= 3)
        {
            codeString = "";
        }
    }

    public void clickNumber(string number)
    {
        codeString += number;
    }
}
