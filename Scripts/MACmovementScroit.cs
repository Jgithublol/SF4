using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;
// MADE BY TOME P. 
public class MACmovementScroit : MonoBehaviour
{
    int mobileImputX = 0;
    int mobileImputY = 0;


    [SerializeField]
    float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    public float smoothImputSpeed = .2f;
    Rigidbody2D rb;


    private Vector3 currentImputVector;
    private Vector3 smoothImputVelocity;



    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float xImput = 0;
        float yImput = 0;


        float keyboardImputX = UnityEngine.Input.GetAxisRaw("Horizontal");
        float keyboardImputY = UnityEngine.Input.GetAxisRaw("Vertical");

        xImput = mobileImputX + keyboardImputX;
        yImput = mobileImputY + keyboardImputY;


        Vector3 moveDir = new Vector3(xImput, yImput);
        currentImputVector = Vector3.SmoothDamp(currentImputVector, moveDir, ref smoothImputVelocity, smoothImputSpeed, moveSpeed);


        GetComponent<Rigidbody2D>().velocity = currentImputVector * moveSpeed;


    }

    public void UpdateMoveDirectionY(int direction)
    {
        mobileImputY = direction;
    }
    public void UpdateMoveDirectionX(int direction)
    {
        mobileImputX = direction;
        Debug.Log(mobileImputX);
    }

    //https://www.youtube.com/watch?v=dQw4w9WgXcQ
}
