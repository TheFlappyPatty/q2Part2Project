using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeanScriptforinventory : MonoBehaviour
{
    public  static int BeanCount;
    public int beansspawned;
    public GameObject Bean;
    public GameObject spawnpoint;
    public Text Beancountshower;


    public void Start()
    {
        InvokeRepeating("spwnabean", 0,0.2f);
    }

    public void Update()
    {
    }
    public void addbean()
    {
        Instantiate(Bean,spawnpoint.transform.position,Quaternion.identity);
        BeanCount += 1;
    }
    public void Deathtoraccon()
    {
        BeanCount = 0;
    }
    public void spawnone()
    {
        Debug.Log("recovering");
        Instantiate(Bean, spawnpoint.transform.position, Quaternion.identity);
        BeanCount += 1;
    }

    public void spwnabean()
    {
        Beancountshower.text = ("" + BeanCount);
        if (BeanCount < beansspawned)
        {
            spawnone();
        }
        if (BeanCount > beansspawned)
        {
            beansspawned = BeanCount;
        }
    }
}
