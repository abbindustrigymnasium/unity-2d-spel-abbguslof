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
            GameObject.FindGameObjectsWithTag("MainCamera").GetComponent<SmoothCameraFollow>() = false;
            collision.GetComponent<BoatMovement>().FloatStrengthY = 10;
        }
        if (collision.gameObject.tag == "CanonBall")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("blaasdasdasdbla");
        }
        Debug.Log("Do something else here");
    }
}
