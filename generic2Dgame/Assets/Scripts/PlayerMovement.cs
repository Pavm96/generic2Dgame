using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindObjectOfType<CharacterController2D>(); //find the character controller script
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; //left or A = -1, right or D = 1
        Debug.Log(Input.GetAxisRaw("Horizontal"));
    }

    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);

    }
}
