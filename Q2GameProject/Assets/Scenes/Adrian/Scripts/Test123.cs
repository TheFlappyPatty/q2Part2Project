using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test123 : MonoBehaviour
{
    public Transform playerLocation;
    private Vector2 Currentlocation;
    //public GameObject locationMarker;
    public GameObject GodHand;
    public float WaitTime;

    // Start is called before the first frame update
    void Start()
    {
        playerLocation = GetComponent<Transform>();

        Currentlocation = new Vector2(playerLocation.position.x, playerLocation.position.y);

        



    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine("MyEvent");
        //if (GameObject.Find("LocalPosition(Clone)") == null)
        //{
        //    Instantiate(locationMarker, Currentlocation, Quaternion.identity);
        //}
    }

    private IEnumerator MyEvent()
    {
        while (true)
        {
            yield return new WaitForSeconds(WaitTime); // wait half a second

            // do things
            if (GameObject.FindGameObjectWithTag("GodHand") == null)
            {
                Instantiate(GodHand, new Vector3(playerLocation.position.x, 5, 0), Quaternion.identity);
                
                while (true)
                {
                    yield return new WaitForSeconds(3f);
                    Destroy(GodHand);
                    yield return false;
                }
            }



        }
    }
}
