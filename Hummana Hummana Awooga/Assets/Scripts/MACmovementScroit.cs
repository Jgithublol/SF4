using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;
// MADE BY TOME P. 
public class MACmovementScroit : MonoBehaviour
{
    int mobileInputX = 0;
    int mobileInputY = 0;


    [SerializeField]
    float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    public float smoothInputSpeed = .2f;
    Rigidbody2D rb;


    private Vector3 currentInputVector;
    private Vector3 smoothInputVelocity;



    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float xInput = 0;
        float yInput = 0;


        float keyboardInputX = UnityEngine.Input.GetAxisRaw("Horizontal");
        float keyboardInputY = UnityEngine.Input.GetAxisRaw("Vertical");

        xInput = mobileInputX + keyboardInputX;
        yInput = mobileInputY + keyboardInputY;


        Vector3 moveDir = new Vector3(xInput, yInput);
        currentInputVector = Vector3.SmoothDamp(currentInputVector, moveDir, ref smoothInputVelocity, smoothInputSpeed, moveSpeed);


        GetComponent<Rigidbody2D>().velocity = currentInputVector * moveSpeed;


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

    //https://www.youtube.com/watch?v=dQw4w9WgXcQ
}
