using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoblieMove : MonoBehaviour
{

    int moblieInput = 0;
    int keyboardInput;

    [SerializeField]
    float moveSpeed = 1.0f;
    Rigidbody2D rb;
    Animator ac;

    // Start is called before the first frame update
    void Start()
    {
        ac = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int moveDir = 0;
        keyboardInput = (int)Input.GetAxisRaw("Horizontal");
        keyboardInput = (int)Input.GetAxisRaw("Vertical");

        moveDir = keyboardInput + moblieInput;
        moveDir = Mathf.Clamp(moveDir, -1, 1);
        Vector2 velocity = rb.velocity;
        velocity.x = moveDir * moveSpeed;
        rb.velocity = velocity;
        ac.SetFloat("xInput", moveDir);

        if (moveDir > 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = 1;
            transform.localScale = scale;
        }
        if (moveDir < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = -1;
            transform.localScale = scale;
        }
    }
    
    // Function for UI
    public void UpdateMoveDirection(int direction)
    {
        moblieInput = direction;
    }

}
