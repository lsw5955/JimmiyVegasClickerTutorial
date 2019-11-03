using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOption : MonoBehaviour
{
    public static bool isLoading = false;

    public void GameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameLoad()
    {
        isLoading = true;
        SceneManager.LoadScene("SampleScene");
    }
}
