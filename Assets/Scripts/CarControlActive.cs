using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour {

    public GameObject CarControl;
    public GameObject VersusCarControl;

    void Start() {
        CarControl.GetComponent<CarUserControl>().enabled = true;
        VersusCarControl.GetComponent<CarAIControl>().enabled = true;
    }
}