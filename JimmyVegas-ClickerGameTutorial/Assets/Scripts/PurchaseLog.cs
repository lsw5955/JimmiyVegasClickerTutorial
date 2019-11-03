using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoCreatingCookies;
    public GameObject autoSellCookies;
    public AudioSource clickSE;

    public void StartAutoCookies()
    {
        clickSE.Play();
        autoCreatingCookies.SetActive(true);
        GlobalCash.moneyCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.numberOfBaker += 1;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.bakePerSec += 1;
    }

    public void StartAutoSell()
    {
        clickSE.Play();
        autoSellCookies.SetActive(true);
        GlobalCash.moneyCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *=2;
        GlobalShop.numberOfshop += 1;
        GlobalShop.turnOffButton = true;
        GlobalShop.shopPerSec += 2;
    }

}
