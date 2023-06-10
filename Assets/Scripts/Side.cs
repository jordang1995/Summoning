using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side : MonoBehaviour
{

    public Side opposingSide;

    public void Summon(Unit unit)
    {
        GameObject.Instantiate(unit.gameObject, transform);
        unit.SetSide(this);
    }
}
