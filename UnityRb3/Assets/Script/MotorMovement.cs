using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorMovement : MonoBehaviour
{
    public float motorSpeed = 1000f; 
    public float maxMotorTorque = 1000f; 
    public float directionChangeInterval = 2f; 

    private HingeJoint2D hingeJoint;
    private float timeSinceDirectionChange;
    private bool movingRight = true;

    void Start()
    {
        hingeJoint = GetComponent<HingeJoint2D>();
        if (hingeJoint != null)
        {
            hingeJoint.useMotor = true; 
        }
        timeSinceDirectionChange = 0f;
    }

    void Update()
    {
        if (hingeJoint != null)
        {
            timeSinceDirectionChange += Time.deltaTime;

            if (timeSinceDirectionChange >= directionChangeInterval)
            {
                movingRight = !movingRight; 
                timeSinceDirectionChange = 0f;
            }

            JointMotor2D motor = hingeJoint.motor;
            motor.motorSpeed = movingRight ? -motorSpeed : motorSpeed; 
            motor.maxMotorTorque = maxMotorTorque;
            hingeJoint.motor = motor;
        }
    }
}
