using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(MainMenuOption.isLoading)
        {
            GlobalCookies.cookieCount = PlayerPrefs.GetInt("saveCookies");

            GlobalCash.moneyCount = PlayerPrefs.GetInt("saveCash");

        }
    }


}
