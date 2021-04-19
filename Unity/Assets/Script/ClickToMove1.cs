using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove1 : MonoBehaviour
{
    public float speed = 10;
    
    private Vector3 targetPosition;
    private bool isMoving;

    const int LEFT_MOUSE_BUTTON = 0;
     
    void Start()
    {
        targetPosition = transform.position;
        isMoving = false;
    }

    void Update()
    {
        if (Input.GetMouseButton (LEFT_MOUSE_BUTTON))
            SetTargetposition ();

        if (isMoving)
            MovingPlayer ();
    }

    void SetTargetposition(){
        Plane plane = new Plane (Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        float point = 0f;

        if (plane.Raycast (ray,out point))
            targetPosition = ray.GetPoint (point);

        isMoving = true;
    }

    void MovingPlayer(){
        transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards (transform.position, targetPosition, speed * Time.deltaTime);
        
        if(transform.position == targetPosition)
        isMoving = false;

        Debug.DrawLine (transform.position, targetPosition, Color.red);
    }

}
