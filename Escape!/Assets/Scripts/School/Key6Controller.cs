using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key6Controller : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private BoxCollider2D keyCollider;
    private GameObject lockClosed, lockObject, lockOpen, key;
    private BoxCollider2D lockCollider, lockObjectCollider;
    private Vector3 shakePower;
    private bool keyReleased;
    private Touch touch;
    private Vector2 touchPosition;
    private float deltaX, deltaY;
    private GameObject button;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        keyCollider = GetComponent<BoxCollider2D>();
        key = GameObject.Find("school_6_key");
        keyCollider.enabled = false;
        rigidBody.isKinematic = true;
        lockClosed = GameObject.Find("school_6_lock_closed");
        lockCollider = lockClosed.GetComponent<BoxCollider2D>();
        lockOpen = GameObject.Find("school_6_lock_open");
        lockOpen.SetActive(false);
        lockObject = GameObject.Find("Lock");
        lockObjectCollider = lockObject.GetComponent<BoxCollider2D>();
        lockObjectCollider.enabled = false;
        button = GameObject.Find("Button_next");
        button.SetActive(false);
    }

    void Update()
    {
        if (Input.touchCount > 0) 
        {
            MoveKey();
        }
        shakePower = Input.acceleration;
        if (shakePower.sqrMagnitude > 5f && !keyReleased) 
        {
            rigidBody.isKinematic = false;
            keyReleased = true;
            keyCollider.enabled = true;
        }
        if (transform.position.y <= -3.5f)
        {
            Destroy(rigidBody);
        }
    }

    private void MoveKey() {
        touch = Input.GetTouch(0);
        touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        switch (touch.phase) 
        {
            case TouchPhase.Began:
                if (keyCollider == Physics2D.OverlapPoint(touchPosition))
                {
                    deltaX = touchPosition.x - transform.position.x;
                    deltaY = touchPosition.y - transform.position.y;
                }
                break;

            case TouchPhase.Moved:
                if (keyCollider == Physics2D.OverlapPoint(touchPosition)) 
                {
                    transform.position = new Vector2(touchPosition.x - deltaX, touchPosition.y - deltaY);
                }
                break;
            
            case TouchPhase.Ended:
                if (keyCollider.bounds.Intersects(lockCollider.bounds)) {
                    lockClosed.SetActive(false);
                    lockObjectCollider.enabled = true;
                    lockObject.SetActive(false);
                    lockOpen.SetActive(true);
                    key.SetActive(false);
                    button.SetActive(true);
                }
                break;
        }
    }
}
