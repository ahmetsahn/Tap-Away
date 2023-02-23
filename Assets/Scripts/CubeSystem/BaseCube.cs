using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BaseCube : MonoBehaviour
{
    
    public CubeData cubeData;
    private Vector3 direction;
    private float speed = 5;
    private bool isMoving = false;
    

    
    
    private void Start()
    {
        if (cubeData != null)
        {
            direction = cubeData.SetDirection(direction);

        }
    }

    private void Update()
    {
        if (isMoving)
        {
            Move();
        }
    }

    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        isMoving = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isMoving = false;
        transform.DOLocalMove(new Vector3(Mathf.RoundToInt(transform.localPosition.x), Mathf.RoundToInt(transform.localPosition.y), Mathf.RoundToInt(transform.localPosition.z)), 1);
    }
    
}
