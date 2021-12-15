using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanSpawn : MonoBehaviour
{

    public Vector2 position1;
    public Vector2 position2;
    public GameObject Beancan1;
    public GameObject Beancan2;
    public GameObject Beancan3;
    private int i = 0;

    // Start is called before the first frame update



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bean1")
        {
            Destroy(Beancan1);
            StartCoroutine(can1());
        }

        if (collision.gameObject.name == "bean2")
        {
            Destroy(Beancan2);
            StartCoroutine(can2());
            
            
        }

        if (collision.gameObject.name == "bean3")
        {
            Destroy(Beancan3);
            StartCoroutine(endGame());
        }
    }
   


    public IEnumerator can1()
    {


        yield return new WaitForSeconds(5);
        while (true)
        {
            
            Beancan2.GetComponent<SpriteRenderer>().enabled = true;
            Beancan2.GetComponent<BoxCollider2D>().enabled = true;
            
            break;
        }

        
    }public IEnumerator can2()
    {
        Debug.Log("Started");

        yield return new WaitForSeconds(5);
        while (true)
        {
            
            Beancan3.GetComponent<SpriteRenderer>().enabled = true;
            Beancan3.GetComponent<BoxCollider2D>().enabled = true;
            
            break;
        }

        StopCoroutine(can2());
    }
    //public IEnumerator can2()
    //{


    //    yield return new WaitForSeconds(5);
    //    while (true)
    //    {
            
    //        Beancan3.GetComponent<SpriteRenderer>().enabled = true;
    //        Beancan3.GetComponent<BoxCollider2D>().enabled = true;

    //        break;
    //    }

    //    StopCoroutine(can2());
    //}

    public IEnumerator endGame()
    {


        yield return new WaitForSeconds(5);
        

        StopCoroutine(endGame());
    }




}
