using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobing : MonoBehaviour
{
    public float FloatStrengthX;
    public float FloatStrengthY;
    public float FloatStrengthRot;

    public float TimeMultX;
    public float TimeMultY;
    public float TimeMultRot;

    Vector2 FloatX;
    Vector2 FloatY;
    Vector3 FloatRot;
    
    float originalX;
    float originalY;
    float originalRot;

    // Start is called before the first frame update
    void Start()
    {
        this.originalX = this.transform.position.x;
        this.originalY = this.transform.position.y;
        this.originalRot = this.transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2((originalX + (Mathf.Sin(Time.time * TimeMultX) * FloatStrengthX)),
            (originalY + (Mathf.Cos(Time.time * TimeMultY) * FloatStrengthY)));
        transform.Rotate(Vector3.forward * (((Mathf.Cos(Time.time) * TimeMultRot) / 10) * FloatStrengthRot));
    }
}
