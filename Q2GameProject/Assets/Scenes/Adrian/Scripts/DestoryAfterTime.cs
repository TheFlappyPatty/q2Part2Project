using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryAfterTime : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("MyEvent");
    }
    private IEnumerator MyEvent()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
            yield return false;
        }
    }

}
