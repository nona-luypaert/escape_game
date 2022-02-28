using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key5Controller : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private BoxCollider2D keyCollider, lockCollider, flagCollider;
    private float deltaX, deltaY;
    private bool moveAllowed;
    private GameObject key, lockOpen, lockClosed, button;

    void Start()
    {
        moveAllowed = false;
        flagCollider = GameObject.Find("school_flag").GetComponent<BoxCollider2D>();
        key = GameObject.Find("school_5_key");
        keyCollider = key.GetComponent<BoxCollider2D>();
        button = GameObject.Find("Button_next");
        button.SetActive(false);
        lockOpen = GameObject.Find("school_5_lock_open");
        lockOpen.SetActive(false);
        lockClosed = GameObject.Find("school_5_lock_closed");
        lockCollider = lockClosed.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            MoveKey();
        }
    }

    private void MoveKey()
    {
        touch = Input.GetTouch(0);
        touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        switch (touch.phase)
        {
            case TouchPhase.Began:
                if (keyCollider == Physics2D.OverlapPoint(touchPosition))
                {
                    deltaX = touchPosition.x - transform.position.x;
                    deltaY = touchPosition.y - transform.position.y;
                    moveAllowed = true;
                }
                break;
            case TouchPhase.Moved:
                if (keyCollider == Physics2D.OverlapPoint(touchPosition) && moveAllowed)
                {
                    transform.position = new Vector2(transform.position.x - deltaX, touchPosition.y - deltaY);
                }
                break;
            case TouchPhase.Ended:
                moveAllowed = false;
                if (keyCollider.bounds.Intersects(lockCollider.bounds)) 
                {
                    key.SetActive(false);
                    lockClosed.SetActive(false);
                    button.SetActive(true);
                    lockOpen.SetActive(true);
                    flagCollider.enabled = false;
                }
                break;
        }
    }
}
