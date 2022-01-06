using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour
{
    bool grounded = false;
    public float accel = 8;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    public CapsuleCollider2D ye;
    public CapsuleCollider2D ye1;
    public CapsuleCollider2D ye2;
    public CapsuleCollider2D na;
    public CapsuleCollider2D na1;
    public CapsuleCollider2D na2;
    public Rigidbody2D rbye;
    public PhysicsMaterial2D bbye;
    Animator a;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        a = gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = true;
            rb2.AddForce(new Vector2(accel, 0));
            ye.enabled = false;
            ye1.enabled = false;
            ye2.enabled = false;
            na.enabled = true;
            na1.enabled = true;
            na2.enabled = true;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = false;
            rb2.AddForce(new Vector2(-accel, 0));
            ye.enabled = true;
            ye1.enabled = true;
            ye2.enabled = true;
            na.enabled = false;
            na1.enabled = false;
            na2.enabled = false;
        }
    }
    void Update()
    {
        grounded = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 0.1f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));
         
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb2.velocity = new Vector2(rb2.velocity.x, 6);
        }

        a.SetFloat("yVelocity", rb2.velocity.y);
        a.SetBool("grounded", grounded);
        float horizValue =Input.GetAxis("Horizontal");

        if (horizValue == 0)
        {
            a.SetBool("Moving", false);
        }
        else
        {
            a.SetBool("Moving", true);
        }
        
        if (Input.GetKeyUp(KeyCode.A))
        {
            rbye.sharedMaterial = bbye;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rbye.sharedMaterial = bbye;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rbye.sharedMaterial = null;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rbye.sharedMaterial = null;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            rbye.sharedMaterial = null;
        }
    }
}
