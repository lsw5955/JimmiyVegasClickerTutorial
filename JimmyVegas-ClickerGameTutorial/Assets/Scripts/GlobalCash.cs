using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static int moneyCount;
    public Text moneyDisplay;
    public int internalMoney;

    private void Update()
    {
        internalMoney = moneyCount;
        moneyDisplay.text = "¥ :" + internalMoney;
    }
}
