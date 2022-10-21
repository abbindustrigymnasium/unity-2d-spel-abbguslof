using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    [Range(-1f,1f)]
    public float ScrollSpeed = 0.5F;
    private float offset;
    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset += (Time.deltaTime * ScrollSpeed) / 10f;
        material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
