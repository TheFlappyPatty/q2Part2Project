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
    public void Update()
    {
        Beancountshower.text = ("" + BeanCount);
        if(beansspawned >BeanCount)
        {
            spawnone();
        }
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
        beansspawned += 1;
    }
}
