using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitHeight : MonoBehaviour
{

    public BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.CompareTag("Player"))
        {
            boxCollider.enabled = false;
            //boxCollider.isTrigger = false;
        }
        else if(collision.collider.CompareTag("Human"))
        {
            boxCollider.enabled = true;
            boxCollider.isTrigger = true;
            
        }
    }
}
