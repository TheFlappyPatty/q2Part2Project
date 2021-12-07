using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difficultybutton : MonoBehaviour
{
    public int DifficultyLevel;
    public Text Difficulty;
    public void Update()
    {
        if (DifficultyLevel >= 4)
        {
            DifficultyLevel = 3;
        }
        if (DifficultyLevel <= 0)
        {
            DifficultyLevel = 1;
        }
        if (DifficultyLevel == 1)
        {
            Difficulty.text = "Easy";
        }
        if (DifficultyLevel == 2)
        {
            Difficulty.text = "Medium";
        }
        if (DifficultyLevel == 3)
        {
            Difficulty.text = "Hard";
        }
    }
    public void PlusDifficulty()
    {
        DifficultyLevel++;
    }
    public void minusDifficulty()
    {
        DifficultyLevel--;
    }
}
