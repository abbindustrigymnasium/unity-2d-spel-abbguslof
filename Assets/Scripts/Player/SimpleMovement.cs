using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{

    public Rigidbody2D playerBody;
    public float speed;

    void Start()
    {
        // use this function to initialize
        // anything
    }

    // Update is called once per frame
    void Update()
    {
        playerBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
    }

}