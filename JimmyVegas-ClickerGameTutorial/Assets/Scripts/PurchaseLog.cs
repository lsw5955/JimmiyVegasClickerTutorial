using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoCreatingCookies;
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
}
