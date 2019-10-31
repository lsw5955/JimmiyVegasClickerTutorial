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
    public static int bakerValue = 1;
    public static bool turnOffButton = false;
    public Text bakerStats;
    public static int numberOfBaker;
    public static int bakePerSec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.moneyCount;
        fakeBakerText.text = "大厨 -" + bakerValue;
        bakerStats.text = "大厨: " + numberOfBaker + "@" + bakePerSec + "/秒";
        if (currentCash >= bakerValue)
        {
            baker.gameObject.SetActive(true);
            fakeBaker.gameObject.SetActive(false);
        }

        if(turnOffButton == true)
        {
            baker.gameObject.SetActive(false);
            fakeBaker.gameObject.SetActive(true);
            turnOffButton = false;
        }
    }
}
