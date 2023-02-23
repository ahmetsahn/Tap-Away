using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    
    public CubeData cubeData;

    [SerializeField]
    private CubeMovement cubeMovement;
  
    private void Start()
    {
        if (cubeData != null)
        {
            cubeMovement.direction = cubeData.SetDirection();

        }
    }

    private void Update()
    {
        if (cubeMovement.isMoving)
        {
            cubeMovement.Move();
        }
    }

    private void OnMouseDown()
    {
        cubeMovement.isMoving = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        cubeMovement.isMoving = false;
        transform.DOLocalMove(new Vector3(Mathf.RoundToInt(transform.localPosition.x), Mathf.RoundToInt(transform.localPosition.y), Mathf.RoundToInt(transform.localPosition.z)), 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
