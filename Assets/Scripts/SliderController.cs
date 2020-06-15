using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderController : MonoBehaviour
{
    private SliderJoint2D Slider;
    private JointMotor2D motor;
    [SerializeField] private float speed;
    [SerializeField] private float startOffset;
    private float defaultY;
    private float yPlusDelta;
    void Start()
    {
        Slider = GetComponentInParent<SliderJoint2D>();
        Slider.useMotor = true;
        defaultY = Slider.attachedRigidbody.position.y;
        yPlusDelta = defaultY + Slider.limits.max;
        if (startOffset >= 0f && startOffset <= 1f)
        {
            Vector2 offsetVector = Slider.attachedRigidbody.position;
            offsetVector.y += (Slider.limits.max * startOffset);
            Slider.attachedRigidbody.position = offsetVector;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Slider.attachedRigidbody.position.y <= defaultY + 0.05)
        {
            JointMotor2D motor = Slider.motor;
            motor.motorSpeed = -speed;
            Slider.motor = motor;
        }
        else if (Slider.attachedRigidbody.position.y > yPlusDelta)
        {
            JointMotor2D motor = Slider.motor;
            motor.motorSpeed = speed;
            Slider.motor = motor;
        }

    }
}
