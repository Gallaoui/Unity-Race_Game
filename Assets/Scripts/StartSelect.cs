using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSelect : MonoBehaviour
{
    public GameObject Car1;
    public GameObject Car2;

    public int Car;
    void Start()
    {
        Car = CarSelection.CarNumber;
        if(Car == 1){
            Car1.SetActive(true);
            Car2.SetActive(false);
        }
        if(Car == 2){
            Car2.SetActive(true);
            Car1.SetActive(false);
        }
    }
}
