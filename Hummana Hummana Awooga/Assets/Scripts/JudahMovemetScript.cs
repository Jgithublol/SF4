using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudahMovemetScript : MonoBehaviour
{

    int mobileInputX = 0;
    int mobileInputY = 0;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    public void UpdateMoveDirectionY(int direction)
    {
        mobileInputY = direction;
    }
    public void UpdateMoveDirectionX(int direction)
    {
        mobileInputX = direction;
        Debug.Log(mobileInputX);
    }
}
