using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] PlayerController playerController;



    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            EvaluatePlayerMovement();
        }
    }

    private void EvaluatePlayerMovement()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up);
        Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition).ToString());

        if (hit.collider != null&&hit.collider.gameObject.tag=="Grass")
        {
            Debug.Log(hit.collider.gameObject.name);
            playerController.MoveTowardsPlace(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
