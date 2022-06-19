using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    
    public Rigidbody rb; 
    public float speed = 10;



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        float zMove = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        Vector3 move = transform.right * xMove + transform.forward * zMove;
        rb.velocity = move;
    }
}
