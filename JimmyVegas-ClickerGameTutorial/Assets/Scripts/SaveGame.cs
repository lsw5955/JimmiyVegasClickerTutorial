﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("saveCookies", GlobalCookies.cookieCount);
        PlayerPrefs.SetInt("saveCash", GlobalCash.moneyCount);

        SceneManager.LoadScene("GameStart");
    }
}
