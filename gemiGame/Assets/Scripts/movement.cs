using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    float speed;

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z + speed);

        if (speed == 0f && Input.GetKey(KeyCode.W))
        {
            speed = 2f;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            speed = speed * 2;
        }

        else if (speed == 12f && Input.GetKey(KeyCode.W))
        {
            speed = -3;
        }

        if (speed == 0f && Input.GetKey(KeyCode.S))
        {
            speed = -3;
        }

        else if (Input.GetKey(KeyCode.S) && speed > 0)
        {
            speed = speed / 2;
        }

        else if (speed < 0 && Input.GetKey(KeyCode.S))
        {
            speed = -3;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (speed < 0)
            {
                while (speed < 0)
                {
                    speed = speed + 0.5f;
                }
                
            }

            if (speed > 0)
            {
                while (speed > 0)
                {
                    speed = speed -0.5f;
                }
            }
        }
    }
    
}
