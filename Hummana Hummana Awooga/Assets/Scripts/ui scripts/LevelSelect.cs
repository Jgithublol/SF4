using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void BabyModeButton()
    {
        SceneManager.LoadScene("baby");
    }
    public void NormieModeButton()
    {
        SceneManager.LoadScene("Normie");
    }
    public void HardModeButton()
    {
        SceneManager.LoadScene("hard");
    }
}
