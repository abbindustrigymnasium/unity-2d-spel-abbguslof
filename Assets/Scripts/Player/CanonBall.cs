using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    private Vector3 ShootDir;
    [SerializeField] private float moveSpeed = 100f;
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private Transform sprite;

    public void Setup(Vector3 ShootDir)
    {
        this.ShootDir = ShootDir;
        transform.eulerAngles = new Vector3(0, 0, Vector3.Angle(gameObject.transform.position, ShootDir));
        sprite.eulerAngles = new Vector3(0, 0, Vector3.Angle(gameObject.transform.position, ShootDir) * rotationSpeed);
        Destroy(gameObject, 5);
    }

    void Update()
    {
        transform.position += ShootDir * moveSpeed * Time.deltaTime;
    }
}
