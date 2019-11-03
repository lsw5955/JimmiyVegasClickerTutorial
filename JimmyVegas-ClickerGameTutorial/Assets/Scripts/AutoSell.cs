using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool sellCookies = false;
    public static int sellIncreasing = 1;
    private int internalSell;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sellIncreasing = GlobalShop.numberOfshop;
        internalSell = sellIncreasing;
        if (sellCookies == false)
        {
            sellCookies = true;
            StartCoroutine(SellTheCookies());
        }
    }

    private IEnumerator SellTheCookies()
    {
        if(GlobalCookies.cookieCount >= internalSell)
        {
            GlobalCookies.cookieCount -= internalSell;
            GlobalCash.moneyCount += internalSell * 2;
        }
        yield return new WaitForSeconds(1);
        sellCookies = false;
    }
}
