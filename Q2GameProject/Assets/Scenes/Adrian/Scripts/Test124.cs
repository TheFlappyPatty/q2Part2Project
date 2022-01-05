using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test124 : MonoBehaviour
{
    public Transform playerLocation;
    private Vector2 Currentlocation;
    //public GameObject locationMarker;
    public GameObject GodHand;
    public float WaitTime;
    public 
    
    // Start is called before the first frame update
    void Start()
    {
        playerLocation = GetComponent<Transform>();

        Currentlocation = new Vector2(playerLocation.position.x, playerLocation.position.y);
        
        StartCoroutine("MyEvent");



    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //if (GameObject.Find("LocalPosition(Clone)") == null)
        //{
        //    Instantiate(locationMarker, Currentlocation, Quaternion.identity);
        //}
    }

    private IEnumerator MyEvent()
    {
        while (GameObject.FindGameObjectWithTag("GodHuman") == true)
        {
            yield return new WaitForSeconds(WaitTime); // wait half a second

            // do things
            if (GameObject.FindGameObjectWithTag("GodHand") == null)
            {
                Instantiate(GodHand, new Vector3(playerLocation.position.x, 11, 0), Quaternion.identity);
                
            }

            

        }
        SceneManager.LoadScene("WIN");
        StopCoroutine(MyEvent());
    }
}
