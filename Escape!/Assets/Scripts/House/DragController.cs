using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragController : MonoBehaviour
{
    private GameObject button, buttonNext;
    private BoxCollider2D drawersCollider;
    private Touch touch;
    private Vector2 touchPosition;
    private bool moveAllowed, end;

    void Start()
    {
        button = GameObject.Find("house_button");
        buttonNext = GameObject.Find("Button_next");
        buttonNext.SetActive(false);
        drawersCollider = GetComponent<BoxCollider2D>();
        moveAllowed = false;
        end = false;
    }

    void Update()
    {
        if (Input.touchCount > 0 && !end)
        {
            touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began: 
                    if (drawersCollider == Physics2D.OverlapPoint(touchPosition))
                    {
                        moveAllowed = true;
                    }
                    break;

                case TouchPhase.Moved:
                    if (moveAllowed) 
                    {
                        transform.position = new Vector2(
                            transform.position.x + touch.deltaPosition.x * 0.001f, 
                            transform.position.y);
                    }
                    break; 
            
                case TouchPhase.Ended: 
                    moveAllowed = false;
                    break;
            }
        } 
        if (transform.position.x >= button.transform.position.x - 0.5f)
        {
            buttonNext.SetActive(true); 
            end = true;
        }
    }
}
