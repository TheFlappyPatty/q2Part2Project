using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winstage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.FindGameObjectWithTag("GodHuman") == null)
        {
            Debug.Log("Switch scene");
            SceneManager.LoadScene("WIN");

        }
    }
}
