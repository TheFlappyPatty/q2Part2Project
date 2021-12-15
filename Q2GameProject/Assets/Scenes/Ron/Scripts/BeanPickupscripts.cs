using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanPickupscripts : MonoBehaviour
{
    public GameObject inventorystuffwork;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        inventorystuffwork.GetComponent<BeanScriptforinventory>().addbean();
        Destroy(gameObject);
    }
    public void Playerhasdied()
    {
        Destroy(gameObject);
    }
}
