using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScripts : MonoBehaviour
{
    public Text statusBox;
    public float cookieCheck;
    public int genChance;
    public bool disasterActive = false;
    public int cookieLoss;


    // Update is called once per frame
    void Update()
    {
        cookieCheck = GlobalCookies.cookieCount/10;
        if(disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);
        if(cookieCheck >= genChance)
        {
            cookieLoss = (int)(GlobalCookies.cookieCount * 0.25);
            GlobalCookies.cookieCount -= cookieLoss;
            statusBox.text = "啊 天啊 你丢了" + cookieLoss + "个" ;
            statusBox.GetComponent<Animator>().Play("StatusAnim");
        }
        yield return new WaitForSeconds(5);
        disasterActive = false;
    }
}
