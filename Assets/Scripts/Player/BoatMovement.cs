using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float FloatStrengthY;
    public float TimeMultY;
    public float FloatStrengthRot;
    public float TimeMultRot;

    Vector2 FloatY;
    float originalY;
    Vector3 FloatRot;
    float originalRot;

    public Rigidbody2D playerBody;
    public float speed;

    void Start()
    {
        this.originalY = this.transform.position.y;
        this.originalRot = this.transform.eulerAngles.z;
    }

    void Update()
    {
        playerBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Horizontal"));
        transform.position = new Vector2(playerBody.transform.position.x, (originalY + (Mathf.Cos(Time.time * TimeMultY) * FloatStrengthY)));
        transform.Rotate(Vector3.forward * (((Mathf.Cos(Time.time) * TimeMultRot) / 10) * FloatStrengthRot));
    }
}