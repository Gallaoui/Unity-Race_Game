using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
   public static int CarNumber;

   public void Car1(){
       CarNumber = 1;
       SceneManager.LoadScene(3);
   }
   public void Car2 (){
       CarNumber = 2;
       SceneManager.LoadScene(3);
   }
}
