using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    private Camera camera;
    private Vector2 mousePos;
    private Vector2 playerPos;
    public int Clamp1 = -30;
    public int Clamp2 = 10;
    [SerializeField] private Transform pfBullet;
    [SerializeField] private Transform MuzzleEnd;
    [SerializeField] private Transform Muzzle;

    void Awake()
    {
    }

    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        RotateCanon();

        if (Input.GetMouseButtonDown(0))
            ShootCanon();
    }

    float CalcAngle(float X, float Y, float X1, float Y1)
    {
        float DistX = (X - X1);
        float DistY = (Y - Y1);
        float Angle = Mathf.Atan2(DistY, DistX) * 180 / Mathf.PI;
        return Angle;
    }
    
    void RotateCanon()
    {
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        playerPos = GameObject.FindGameObjectWithTag("Canon").transform.position;
        float Angle = CalcAngle(playerPos.x, playerPos.y, mousePos.x, mousePos.y);
        GameObject.FindGameObjectWithTag("Canon").transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Angle, Clamp1, Clamp2));
    }

    void ShootCanon()
    {
        Transform CanonBallTransform = Instantiate(pfBullet, MuzzleEnd.position, Quaternion.identity);

        Vector3 ShootDir = (CanonBallTransform.position - Muzzle.position).normalized;
        CanonBallTransform.GetComponent<CanonBall>().Setup(ShootDir);
    }
}
