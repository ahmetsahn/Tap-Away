using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/CubeData")]
public class CubeData : ScriptableObject
{
    

    
    public Directions directions;

    public enum Directions
    {
        left,
        right,
        up,
        down,
        forward,
        back
    }

    public Vector3 SetDirection(Vector3 direction)
    {
        switch (directions)
        {
            case Directions.left:
                direction = Vector3.left;
                break;
            case Directions.right:
                direction = Vector3.right;
                break;
            case Directions.up:
                direction = Vector3.up;
                break;
            case Directions.down:
                direction = Vector3.down;
                break;
            case Directions.forward:
                direction = Vector3.forward;
                break;
            case Directions.back:
                direction = Vector3.back;
                break;
            default:
                break;
        }

        return direction;
    }

    
}
