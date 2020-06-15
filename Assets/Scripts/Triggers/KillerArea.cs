using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerArea : MonoBehaviour
{
    [SerializeField] private GameLogicScript logic;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            logic.loss();
        }   
    }
}
