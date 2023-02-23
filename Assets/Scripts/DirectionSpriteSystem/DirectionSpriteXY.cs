using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionSpriteXY : MonoBehaviour
{
    private void Start()
    {
        switch (GetComponentInParent<BaseCube>().cubeData.directions)
        {
            case CubeData.Directions.left:
                transform.localRotation = Quaternion.Euler(90, 180, 0);
                break;
            case CubeData.Directions.right:
                transform.localRotation = Quaternion.Euler(90, 0, 0);
                break;
            case CubeData.Directions.up:
                transform.localRotation = Quaternion.Euler(90, 0, 90);
                break;
            case CubeData.Directions.down:
                transform.localRotation = Quaternion.Euler(90, 0, 270);
                break;
            default:
                break;
        }


    }
}
