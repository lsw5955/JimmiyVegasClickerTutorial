using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookies : MonoBehaviour
{
    public bool creatingCookies = false;
    public static int cookieIncreasing = 1;
    private int internalIncreasing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalIncreasing = cookieIncreasing;
        if (creatingCookies == false)
        {
            creatingCookies = true;
            StartCoroutine(CreateTheCookies());
        }
    }

    private IEnumerator CreateTheCookies()
    {
        GlobalCookies.cookieCount += internalIncreasing;
        yield return new WaitForSeconds(1);
        creatingCookies = false;
    }
}
