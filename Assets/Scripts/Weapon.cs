using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float range;

    public RaycastHit2D[] GetUnitsInRange()
    {
        return Physics2D.CircleCastAll(transform.position, range, Vector2.zero, 0);
    }

}
