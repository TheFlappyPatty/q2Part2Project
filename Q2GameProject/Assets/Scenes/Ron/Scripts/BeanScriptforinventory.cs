using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeanScriptforinventory : MonoBehaviour
{
    public int BeanCount;
    public GameObject Bean;
    public Text Beancountshower;
    public void Update()
    {
        Beancountshower.text = ("" + BeanCount);
    }
    public void addbean()
    {
        BeanCount++;
        Instantiate(Bean).transform.localPosition = gameObject.transform.position;
    }
}
