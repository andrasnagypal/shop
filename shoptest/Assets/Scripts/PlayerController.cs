using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 destination;
    IEnumerator currentAction;

    private void Awake()
    {
        MoveTowardsPlace(new Vector2(3, 0));
    }
    public void MoveTowardsPlace(Vector2 pointToReach)
    {
        destination = pointToReach;
        if(currentAction!=null)
        StopCoroutine(currentAction);
        if(pointToReach.y>transform.position.y)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        else
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        currentAction = Move();
        StartCoroutine(currentAction);
    }


    IEnumerator Move()
    {
        yield return null;
        gameObject.transform.position = destination;
    }
}
