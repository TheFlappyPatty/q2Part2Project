﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeanScriptforinventory : MonoBehaviour
{
    public  static int BeanCount;
    public GameObject Bean;
    public Text Beancountshower;
    public void Update()
    {
        Beancountshower.text = ("" + BeanCount);
    }
    public void addbean()
    {
        Instantiate(Bean,transform.position,Quaternion.identity);
        BeanCount += 1;
    }
}
