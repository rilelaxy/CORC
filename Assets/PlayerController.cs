using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    Vector2 lastClickedPos;
    bool moving;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }
        
        if (moving)
        {
            Vector2 moveDirection = (lastClickedPos - (Vector2)transform.position).normalized;
            
            float distance = Vector2.Distance(transform.position, lastClickedPos);

            if (distance > 0.1f)
            {
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.velocity = moveDirection * speed;
            }
            else
            {
                moving = false;
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.velocity = Vector2.zero;
            }
        }
    }
}
