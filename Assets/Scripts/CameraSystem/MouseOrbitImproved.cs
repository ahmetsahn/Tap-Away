using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOrbitImproved : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    
    [SerializeField]
    private float distance = 10.0f;
    
    [SerializeField]
    private float sensitivity = 5.0f; 
    
    private float x = 0.0f;
    
    private float y = 0.0f;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * sensitivity;
            y -= Input.GetAxis("Mouse Y") * sensitivity;

            Quaternion rotation = Quaternion.Euler(y, x, 0);

            transform.position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;
            transform.rotation = rotation;
        }
    }
}
