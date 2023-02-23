using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Vector3 direction { get; set; }
    public bool isMoving { get; set; } = false;

    private float speed = 5;

    public void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
