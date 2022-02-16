using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveController : MonoBehaviour
{
    public GameObject objectToActivate;
    public bool activate;

    public void ActivateObject()
    {
        if (activate) {
            objectToActivate.SetActive(true);
        } else {
            objectToActivate.SetActive(false);
        }
    }
}
