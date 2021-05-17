using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    //public Camera cam;
    public Rigidbody2D rb;
    private Vector2 mouseScreenPosition;

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position
        mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        // The direction the player will look at
        Vector2 lookAt = mouseScreenPosition - rb.position;
        // Calculate the rotation in radian
        float Angle= Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg - 180f;
        if (distance(mouseScreenPosition.x, mouseScreenPosition.y, transform.position.x, transform.position.y) > 1)
        {
            rb.rotation = Angle;
        }
    }

    float distance(float x1, float y1, float x2, float y2)
    {
        return Mathf.Sqrt(Mathf.Pow(x1 - x2, 2) + Mathf.Pow(y1 - y2, 2));
    }
}
