using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkShip : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Boat")
        {
            collision.GetComponent<BoatMovement>().FloatStrengthY = 10;
        }
        if (collision.gameObject.tag == "CanonBall")
        {
            Destroy(collision);
        }
        Debug.Log("Do something else here");
    }
}
