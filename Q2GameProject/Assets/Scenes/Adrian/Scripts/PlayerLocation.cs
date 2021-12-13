using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{

    public Transform playerLocation;
    private Vector2 Currentlocation;
    public GameObject locationMarker;
    
    // Start is called before the first frame update
    void Start()
    {
        playerLocation = GetComponent<Transform>();

        Currentlocation = new Vector2(playerLocation.position.x, playerLocation.position.y);


        
        
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (GameObject.Find("LocalPosition(Clone)") == null)
        {
            Instantiate(locationMarker, Currentlocation, Quaternion.identity);
        }


        
    }
}
