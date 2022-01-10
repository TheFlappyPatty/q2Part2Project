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
    public float Difficulty;
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
            yield return new WaitForSeconds(Difficulty); // wait half a second

            // do things
            if (GameObject.FindGameObjectWithTag("Player") == true || GameObject.FindGameObjectWithTag("GodHuman") == true)
            {
                Instantiate(GodHand, new Vector3(Random.Range(-1, 40) , 11, 0), Quaternion.identity);
                
            }

            

        }
        SceneManager.LoadScene("WIN");
        StopCoroutine(MyEvent());
    }
}
