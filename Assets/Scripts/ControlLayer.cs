using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Character))]
public class ControlLayer : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    //private Character character;
    private Rigidbody2D rigidBody;
    private TriggerDetector groundDetector;
    public bool onGround;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        groundDetector = GetComponentInChildren<TriggerDetector>();
    } 

    void Jump()
    {
        if (groundDetector.InTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
        }
    }

    void Move()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector2 movement = new Vector2(deltaX, rigidBody.velocity.y);
        rigidBody.velocity = movement;
    }


    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
}
