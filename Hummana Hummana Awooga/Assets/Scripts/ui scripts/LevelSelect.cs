using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void BabyModeButton()
    {
        SceneManager.LoadScene("Big Dungeon");
    }
    public void NormieModeButton()
    {
        SceneManager.LoadScene("Normal Dungeon");
    }
    public void HardModeButton()
    {
        SceneManager.LoadScene("Small Dungeon");
    }
}
