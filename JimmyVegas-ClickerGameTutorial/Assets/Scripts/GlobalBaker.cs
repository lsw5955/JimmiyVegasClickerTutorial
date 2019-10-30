using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public Button baker;
    public Button fakeBaker;
    public Text bakerText;
    public Text fakeBakerText;
    private int currentCash;
    public static int bakerValue = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.moneyCount;
        fakeBakerText.text = "大厨 -" + bakerValue;
        if (currentCash >= bakerValue)
        {
            baker.gameObject.SetActive(true);
            fakeBaker.gameObject.SetActive(false);
        }
        else
        {
            baker.gameObject.SetActive(false);
            fakeBaker.gameObject.SetActive(true);
        }
    }
}
