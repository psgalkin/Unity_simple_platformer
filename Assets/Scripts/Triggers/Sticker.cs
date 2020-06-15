using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticker : MonoBehaviour
{
    private Vector3 prevPosition;
    private Transform sticked;
    bool isActive;
    
    void Start()
    {
        isActive = false;   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { 
            sticked = collision.transform;
            isActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { 
            sticked = null;
            isActive = false;
        }
    }

    void Update()
    {
        if (isActive) { 

            Vector3 deltaPos = transform.position - prevPosition;
            sticked.position += deltaPos;
        }
        prevPosition = transform.position;
    }
}
