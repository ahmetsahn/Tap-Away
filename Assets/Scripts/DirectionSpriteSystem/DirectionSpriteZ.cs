using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionSpriteZ : MonoBehaviour
{
    private void Start()
    {
        switch (GetComponentInParent<BaseCube>().cubeData.directions)
        {
            case CubeData.Directions.forward:
                transform.localRotation = Quaternion.Euler(90, 270, 0);
                break;
            case CubeData.Directions.back:
                transform.localRotation = Quaternion.Euler(90, 90, 0);
                break;
            default:
                break;
        }
    }
    
}
