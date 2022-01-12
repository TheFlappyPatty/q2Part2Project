using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject Beaninventory;
    public void Start()
    {
       Beaninventory = GameObject.Find("Inventory");
    }

    public  void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = spawnpoint.transform.position;

       Beaninventory.GetComponent<BeanScriptforinventory>().Deathtoraccon();
    }


}