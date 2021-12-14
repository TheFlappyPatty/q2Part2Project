using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelselectButton : MonoBehaviour
{
    public string level1;
   public void Level1start()
    {
        SceneManager.LoadScene(level1);
    }
}
