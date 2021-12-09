using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeanScriptforinventory : MonoBehaviour
{
    public int BeanCount;
    public GameObject Bean;
    public void addbean()
    {
        BeanCount++;
        Instantiate(Bean).transform.localPosition = transform.localPosition;
    }
}
