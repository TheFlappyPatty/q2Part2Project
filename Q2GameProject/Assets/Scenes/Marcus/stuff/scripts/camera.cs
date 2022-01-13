using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public Slider slidyX;
    public Slider notslidyX;
    public float xaxisss;
    public float Yaxisss;

    void Update()
    {
        offset.x = slidyX.value;
        offset.y = notslidyX.value;
        offset.z =  -10f;

        slidyX.value = xaxisss;
        notslidyX.value = Yaxisss;

        if (Input.GetKey(KeyCode.A))
        {
          xaxisss -= .01f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            xaxisss += .01f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Yaxisss += .01f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Yaxisss -=.01f;
        }
        // AAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHH
        if (Input.GetKeyUp(KeyCode.A))
        {
            xaxisss += .1f;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            xaxisss -= .1f;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Yaxisss -= .1f;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Yaxisss += .1f;
        }
        if (xaxisss >= 1.1)
        {
            xaxisss = 1;
        }
        if(xaxisss <= -1.1)
        {
            xaxisss = -1;
        }
        if (Yaxisss >= 1.1)
        {
            Yaxisss = 1;
        }
        if (Yaxisss <= -1.1)
        {
            Yaxisss = -1;
        }
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }



}