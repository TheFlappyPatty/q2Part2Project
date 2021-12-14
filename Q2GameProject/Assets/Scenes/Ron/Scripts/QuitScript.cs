using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour
{
    public GameObject Quitmenus;
    public GameObject Settingsmenu;
    public bool quitmenu;
    public void Quiting()
    {
        if(quitmenu == false)
        {
            Application.Quit();
        } else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    public void creditsstuffmover()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void Quitmenu()
    {
        Quitmenus.SetActive(true);
    }
    public void cancel()
    {
        Quitmenus.SetActive(false);
        if(quitmenu == true)
        {
            quitmenu = false;
        }
    }
    public void Settings()
    {
        Settingsmenu.SetActive(true);
    }
    public void closesettings()
    {
        Settingsmenu.SetActive(false);
    }
    public void quitmainmenu()
    {
        quitmenu = true;
        Quitmenus.SetActive(true);
    }
}
