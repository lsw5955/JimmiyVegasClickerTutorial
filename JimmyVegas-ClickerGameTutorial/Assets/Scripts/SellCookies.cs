using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookies : MonoBehaviour
{
    public Text statusText;
    private AnimatorStateInfo animInfo;
    private Animator anim;

    private void Start()
    {
        statusText.text = "";
        anim = statusText.GetComponent<Animator>();
    }

    private void Update()
    {
        animInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (animInfo.IsName("StatusAnim") && animInfo.normalizedTime >= 1.0f)
        {
            anim.Play("Idle");
            statusText.text = "";
        }
    }

    public void ClickTheButton()
    {
        if(GlobalCookies.cookieCount <= 0)
        {
            statusText.text = "没钱你想啥呢啊?";
            anim.Play("StatusAnim");
        }
        else
        {
            GlobalCookies.cookieCount--;
            GlobalCash.moneyCount += 2;
        }
    }
}
