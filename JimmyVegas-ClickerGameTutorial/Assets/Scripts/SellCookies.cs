using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookies : MonoBehaviour
{
    public Text statusText;
    private AnimatorStateInfo animInfo;
    private Animator anim;
    //public AudioSource[] clickSE;
    public AudioClip[] testAudioClip;

    private void Start()
    {
        statusText.text = "";
        anim = statusText.GetComponent<Animator>();
    }

    private void Update()
    {
        animInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (!animInfo.IsName("Idle") && animInfo.normalizedTime >= 1.0f)
        {
            anim.Play("Idle");
            statusText.text = "";
        }
    }

    public void ClickTheButton()
    {
        //clickSE[(int)Random.Range(0,2)].Play();
        AudioSource.PlayClipAtPoint(testAudioClip[(int)Random.Range(0, 2)], new Vector3(0,0,-10),0.5f);
        if (GlobalCookies.cookieCount <= 0)
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
