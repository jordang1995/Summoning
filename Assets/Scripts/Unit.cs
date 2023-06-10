using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public enum State
    {
        None, Walking, Attacking
    }

    public Side side;
    private Side opposingSide;
    public float speed;
    public float range;

    public State state = State.None;

    public void SetSide(Side side)
    {
        this.side = side;
        opposingSide = side.opposingSide;
        transform.tag = side.tag;
        Debug.Log(opposingSide.gameObject.tag);
    }

    public void Update()
    {
        CheckAttackRange();

        switch (state)
        {
            case State.None:
                break;
            case State.Walking:
                Walk();
                break;
            case State.Attacking:
                break;
        }
    }

    public void Walk()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    public bool IsEnemyInRange()
    {
        return false;
    }

    public void CheckAttackRange()
    {
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, range, Vector2.zero, 0);
        foreach (RaycastHit2D hit in hits)
        {
            Debug.Log(opposingSide.gameObject.tag);
            //Debug.Log(hit.collider.gameObject.CompareTag(opposingSide.gameObject.tag));
         /*   if (hit.collider.gameObject.CompareTag(opposingSide.gameObject.tag))
            {
                //Debug.Log(hit.collider.gameObject.tag);
            }*/
        }
    }

}
