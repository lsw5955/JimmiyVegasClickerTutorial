using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies : MonoBehaviour
{
    public static int cookieCount;
    public Text cookieDisplay;
    public int internalCookie;

    private void Update()
    {
        internalCookie = cookieCount;
        cookieDisplay.text = "Cookie :" + internalCookie;
    }
}
