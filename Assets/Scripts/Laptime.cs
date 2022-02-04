using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //include UI from unity

public class Laptime : MonoBehaviour
{
    public static int MinCount;
    public static int SecCount;
    public static float MillCount;
    public static string Timing,m,s;

    public GameObject TimingBox;

    // Update is called once per frame
    void Update()
    {
        MillCount += Time.deltaTime * 10;
        if (MillCount >= 10)
        {
            MillCount = 0;
            SecCount += 1;
        }

        if (SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }

        if(SecCount <= 9)
        {
           s = "0" + SecCount.ToString() + ":";
        }else
        {
            s = "" + SecCount.ToString() + ":";
        }

        if (MinCount <= 9)
        {
           m = "0" + MinCount.ToString() + ":";
        }else
        {
            m = "" + MinCount.ToString() + ":";
        }
        Timing = m + s + MillCount.ToString("F0");
        TimingBox.GetComponent<Text> ().text = Timing;
    }
}
