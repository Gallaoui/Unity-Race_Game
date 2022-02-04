using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class LaptimeCompleted : MonoBehaviour
{
    public GameObject LapCompleted;
    public GameObject HalfLap;

    public GameObject Btiming;

    public GameObject BtimingBox;
    public GameObject LapCounter;
    public int Lapdone;

    public GameObject FinishCam;
    void OnTriggerEnter() {
        Lapdone += 1;
        Laptime.SecCount = 0;
        Laptime.MinCount = 0;
        Laptime.MillCount = 0;
        LapCounter.GetComponent<Text>().text = "2/" + Lapdone;
        LapCompleted.SetActive(false); //to avoid multiple Saved time
        HalfLap.SetActive(true);
        if(Lapdone == 2){
            CarController.m_Topspeed = 0.0f;
            FinishCam.SetActive(true);
            Btiming.GetComponent<Text> ().text = "" + Laptime.Timing;
        }
    }
}
