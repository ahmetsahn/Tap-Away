using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDirectionManager : MonoBehaviour
{
    
    private void Start()
    {
        switch (GetComponentInParent<BaseCube>().cubeData.directions)
        {
            case CubeData.Directions.left:
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                break;
            case CubeData.Directions.right:
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                break;
            case CubeData.Directions.up:
                transform.localRotation = Quaternion.Euler(0, 90, 0);
                break;
            case CubeData.Directions.down:
                transform.localRotation = Quaternion.Euler(0, 270, 0);
                break;
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
