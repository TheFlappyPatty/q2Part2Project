using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGodHand : MonoBehaviour
{
    public GameObject GodHand;
    public float WaitTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine("MyEvent");
        
    }

    // Update is called once per frame

    private IEnumerator MyEvent()
    {
        while (true)
        {
            yield return new WaitForSeconds(WaitTime); // wait half a second

            // do things
            if (GameObject.FindGameObjectWithTag("GodHand") == null)
            {
                Instantiate(GodHand, new Vector3(transform.position.x, 5, 0), Quaternion.identity);
            }
            

            
        }
    }

}
