using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public AudioSource clickSE;

    public void ClickTheButton()
    {
        clickSE.Play();
        GlobalCookies.cookieCount++ ;
    }
}
