using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
public GameObject TheCar;
public float CarX;
public float CarY;// x,y,z of Camera will following the Car
public float CarZ;
    // Update is called once per frame
    void Update()
    {
        CarX = TheCar.transform.eulerAngles.x;
        CarY = TheCar.transform.eulerAngles.y;// take the values of rotation from Car
        CarZ = TheCar.transform.eulerAngles.z;
        
        transform.eulerAngles = new Vector3(CarX - CarX, CarY , CarZ - CarZ);
    }
}
