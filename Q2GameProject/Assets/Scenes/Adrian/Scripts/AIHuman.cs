using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHuman : MonoBehaviour
{
    public float speed = 3f;
    public float detectDistance = 5f;
    [SerializeField] Transform target;
    public Collider2D player;
    public float hightCap = 3;
    public bool hightCapOn = false;
    public Rigidbody2D rb2;
    public bool grounded;
    public float jumpStrength = 400;
    public float groundLevel;
    // Debugging Variables
    public float offset;


    void Start()
    {
        player = GetComponent<Collider2D>();
        rb2 = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //rotate humans head

        if (target != null)
        {
            offset = -90f;


            Vector2 _dir = target.position - transform.position;
            _dir.Normalize();
            float _angle = Mathf.Atan2(_dir.y, _dir.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, _angle + offset));

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        //if (transform.position.y > hightCap)
        //{
        //    //Set height limit
        //    transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.x, hightCap, 0), transform.position.z);
        //}
        // For jumping
        if (Input.GetKeyDown(KeyCode.W) && grounded == true)
        {
            rb2.AddForce(new Vector2(0, jumpStrength));
        }

    }

    private void LateUpdate()
    {
        target = FindTarget();
        
    }

    
    //IDK
    Transform FindTarget()
    {
        if(target == null)
        {
            Transform _target = GameObject.FindGameObjectWithTag("player").transform;

            if(_target != null)
            {
                float _dist = Vector2.Distance(_target.position, transform.position);

                if (_dist <= detectDistance)
                {
                    return _target;
                } else
                {
                    return null;
                }

            } else {
                return null;
            }
        } else
        {
            float _dist = Vector2.Distance(target.position, transform.position);

            if (_dist <= detectDistance)
            {
                return target;
            }
            else
            {
                return null;
            }
        }
    }

    //Destory player when collidion is detected
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //or gameObject.SetActive(false);
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
