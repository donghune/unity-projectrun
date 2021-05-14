using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRigidbody2D;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {
        myRigidbody2D.velocity = new Vector2(moveSpeed, myRigidbody2D.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jumpForce);
        }
    }
}
