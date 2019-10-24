using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 position;

    // Update is called once per frame
    void Update()
    {
        //Input

        position.x = Input.GetAxisRaw("Horizontal");
        position.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        //Movement

        rb.MovePosition(rb.position + position * moveSpeed * Time.fixedDeltaTime);
    }
}
