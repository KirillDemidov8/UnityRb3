using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMotorMovement : MonoBehaviour
{
    public float speed = 2f; 
    public float leftLimit = -5f; 
    public float rightLimit = 5f; 

    private bool movingRight = true;

    void Update()
    {
        
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= rightLimit)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= leftLimit)
            {
                movingRight = true;
            }
        }
    }
}
