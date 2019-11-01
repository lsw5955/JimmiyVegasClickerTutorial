using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public AudioSource clickSE;
    public int creaseVolume = 1;

    public void ClickTheButton()
    {
        clickSE.Play();
        GlobalCookies.cookieCount += creaseVolume;
    }
}
