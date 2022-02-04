using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapCompleted : MonoBehaviour
{
     public GameObject LapCompleted;
    public GameObject HalfLap;

    void OnTriggerEnter() {
        
        LapCompleted.SetActive(true); //to avoid multiple Saved time
        HalfLap.SetActive(false);
    }
}
