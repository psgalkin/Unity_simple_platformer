using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Character : MonoBehaviour
{
    public Transform Visual;

    Rigidbody2D rigidBody2D;
    TriggerDetector triggerDetector;
    public bool inTrigger;
    Animator animator;
    float visualDirection;
    private static readonly int Speed = Animator.StringToHash("speed");

    // Start is called before the first frame update
    void Start()
    {
        visualDirection = 1.0f;
        rigidBody2D = GetComponent<Rigidbody2D>();
        triggerDetector = GetComponentInChildren<TriggerDetector>();
        animator = GetComponentInChildren<Animator>();
        inTrigger = true;
        
    }



    private void Update()
    {
        //float deltaX = Input.GetAxis("Horizontal") * MoveForce * Time.deltaTime;
        //Vector2 movement = new Vector2(deltaX, rigidBody2D.velocity.y);
        //rigidBody2D.velocity = movement;
        //Jump();
         
        float vel = rigidBody2D.velocity.x;
        inTrigger = triggerDetector.InTrigger;
        if (vel < -0.01f) {
            visualDirection = -1.0f;
            Debug.Log($"vel={vel:f5} visualDirection={visualDirection}");
        } else if (vel > 0.01f) {
            visualDirection = 1.0f;
            Debug.Log($"vel={vel:f5} visualDirection={visualDirection}");
        }

        Vector3 scale = Visual.localScale;
        scale.x = visualDirection;
        Visual.localScale = scale;

        animator.SetFloat(Speed, Mathf.Abs(vel));
    }
}
