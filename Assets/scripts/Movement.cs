using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] LayerMask groundlayer;
    private Rigidbody2D body;
    [SerializeField] float speed;
    private Animator anim;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        //refrences
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        // flips player when moving
        if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(4, 4, 4);
        }
        else if (horizontalInput < -0.01)
        {
            transform.localScale = new Vector3(-4, 4, 4);
        }
        //jump
        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, speed);

        }
        // set animations
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", isGrounded());
    }
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("Jump");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundlayer);
        return raycastHit.collider != null;
    }
}
