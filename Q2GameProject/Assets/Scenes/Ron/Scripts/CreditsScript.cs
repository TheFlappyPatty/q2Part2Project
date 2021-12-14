using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public GameObject Ron;
    public GameObject Marcus;
    public GameObject Adrian;
    public GameObject Joseph;
    public GameObject Nev;
    public GameObject kasi;
    public GameObject may;
    public int scroler;

    public void next()
    {
        scroler++;
    }
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void back()
    {
        scroler--;
    }
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            scroler--;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            scroler++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            scroler--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            scroler++;
        }


        if(scroler < 1)
        {
            scroler = 7;
        }
        if(scroler > 7)
        {
            scroler = 1;
        }

        if (scroler == 1)
        {
            Ron.SetActive(true);
            Marcus.SetActive(false);
            Adrian.SetActive(false);
            Joseph.SetActive(false);
            Nev.SetActive(false);
            kasi.SetActive(false);
            may.SetActive(false);
        }
        if (scroler == 2)
        {
            Ron.SetActive(false);
            Marcus.SetActive(true);
            Adrian.SetActive(false);
            Joseph.SetActive(false);
            Nev.SetActive(false);
            kasi.SetActive(false);
            may.SetActive(false);
        }
        if (scroler == 3)
        {
            Ron.SetActive(false);
            Marcus.SetActive(false);
            Adrian.SetActive(true);
            Joseph.SetActive(false);
            Nev.SetActive(false);
            kasi.SetActive(false);
            may.SetActive(false);
        }
        if (scroler == 4)
        {
            Ron.SetActive(false);
            Marcus.SetActive(false);
            Adrian.SetActive(false);
            Joseph.SetActive(true);
            Nev.SetActive(false);
            kasi.SetActive(false);
            may.SetActive(false);
        }
        if (scroler == 5)
        {
            Ron.SetActive(false);
            Marcus.SetActive(false);
            Adrian.SetActive(false);
            Joseph.SetActive(false);
            Nev.SetActive(true);
            kasi.SetActive(false);
            may.SetActive(false);
        }
        if (scroler == 6)
        {
            Ron.SetActive(false);
            Marcus.SetActive(false);
            Adrian.SetActive(false);
            Joseph.SetActive(false);
            Nev.SetActive(false);
            kasi.SetActive(true);
            may.SetActive(false);
        }
        if (scroler == 7)
        {
            Ron.SetActive(false);
            Marcus.SetActive(false);
            Adrian.SetActive(false);
            Joseph.SetActive(false);
            Nev.SetActive(false);
            kasi.SetActive(false);
            may.SetActive(true);
        }
    }
}
