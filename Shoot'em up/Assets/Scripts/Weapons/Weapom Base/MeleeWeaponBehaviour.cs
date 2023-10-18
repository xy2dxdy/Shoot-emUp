using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponBehaviour : MonoBehaviour
{
    protected Vector3 direction;

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirX = direction.x;
        float dirY = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        if (dirX < 0 && dirY == 0) //left
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
        }
        else if (dirX == 0 && dirY < 0) // down
        {
            scale.y *= -1;
        }
        else if (dirX == 0 && dirY > 0)//up
        {
            scale.x *= -1;
        }
        else if (dirX > 0 && dirY > 0) // right up
        {
            rotation.z = 0;
        }
        else if (dirX > 0 && dirY < 0)//right down
        {
            rotation.z = 0;
            scale.y *= -1;
        }
        else if (dirX < 0 && dirY > 0)//left up
        {
            rotation.z = 0;
            scale.x *= -1;
        }
        else if (dirX < 0 && dirY < 0)//left down
        {
            rotation.z = 0;
            scale.y *= -1;
            scale.x *= -1;
        }
        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
