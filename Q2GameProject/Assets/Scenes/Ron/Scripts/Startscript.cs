using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Startscript : MonoBehaviour
{
    public GameObject startgamemenu;
    public string Level;
    public void Openmenu()
    {
        startgamemenu.SetActive(true);
    }
    public void Easy()
    {
        GetComponent<difficultybutton>().DifficultyLevel = 1;
        SceneManager.LoadScene(Level);
    }
    public void Medium()
    {
        GetComponent<difficultybutton>().DifficultyLevel = 2;
        SceneManager.LoadScene(Level);
    }
    public void Hard()
    {
        GetComponent<difficultybutton>().DifficultyLevel = 3;
        SceneManager.LoadScene(Level);
    }
}
