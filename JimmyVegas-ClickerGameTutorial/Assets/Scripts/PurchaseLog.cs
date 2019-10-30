using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoCreatingCookies;

    public void StartAutoCookies()
    {
        autoCreatingCookies.SetActive(true);
    }
}
