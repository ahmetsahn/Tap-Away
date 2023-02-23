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

    public Vector3 SetDirection()
    {
        switch (directions)
        {
            case Directions.left:
                return Vector3.left;
               
            case Directions.right:
                return Vector3.right;
              
            case Directions.up:
                return Vector3.up;
               
            case Directions.down:
                return Vector3.down;
                
            case Directions.forward:
                return Vector3.forward;
                
            case Directions.back:
                return Vector3.back;
                
            default:
                break;
        }

        return Vector3.zero;
    }

    
}
