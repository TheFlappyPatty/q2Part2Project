using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAi : MonoBehaviour
{
    public float jumpStrength = 400;
    public bool grounded;
    public Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            rb2.AddForce(new Vector2(0, jumpStrength));
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }
}
