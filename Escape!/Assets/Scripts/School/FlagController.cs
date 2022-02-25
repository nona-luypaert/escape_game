using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private BoxCollider2D flagCollider;
    private float deltaX, deltaY;
    private bool moveAllowed;
    
    void Start()
    {
        moveAllowed = false;
        flagCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            MoveFlag();
        }
    }

    private void MoveFlag() 
    {
        touch = Input.GetTouch(0);
        touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        switch (touch.phase)
        {
            case TouchPhase.Began:
                if (flagCollider == Physics2D.OverlapPoint(touchPosition))
                {
                    deltaX = touchPosition.x - transform.position.x;
                    deltaY = touchPosition.y - transform.position.y;
                    moveAllowed = true;
                }
                break;
            case TouchPhase.Moved:
                if (flagCollider == Physics2D.OverlapPoint(touchPosition) && moveAllowed)
                {
                    transform.position = new Vector2(transform.position.x - deltaX, touchPosition.y - deltaY);
                }
                break;
            case TouchPhase.Ended:
                moveAllowed = false;
                break;
        }

    }
}
