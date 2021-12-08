using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject checky;

    public void die()
    {
        gameObject.transform.localPosition = new Vector2(checky.transform.position.x, checky.transform.position.y + 2);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            die();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Checkypointy")
        {
            checky = collision.collider.gameObject;
        }
    }
}
