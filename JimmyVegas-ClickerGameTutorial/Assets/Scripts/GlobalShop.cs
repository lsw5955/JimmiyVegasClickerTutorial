using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public Button shop;
    public Button fakeShop;
    public Text shopText;
    public Text fakeShopText;
    private int currentCash;
    public static int shopValue = 1;
    public static bool turnOffButton = false;
    public Text shopStats;
    public static int numberOfshop;
    public static int shopPerSec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.moneyCount;
        fakeShopText.text = "商店 -" + shopValue;
        shopStats.text = "商店: " + numberOfshop + " ¥ " + shopPerSec + "/秒";
        if (currentCash >= shopValue)
        {
            shop.gameObject.SetActive(true);
            fakeShop.gameObject.SetActive(false);
        }

        else//if(turnOffButton == true)
        {
            shop.gameObject.SetActive(false);
            fakeShop.gameObject.SetActive(true);
            turnOffButton = false;
        }
    }
}
