using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    

    public void PlayGame () {
        SceneManager.LoadScene(3);
    }
    public void CarSelection () {
        SceneManager.LoadScene(2);
    }
    public void MainMenu () {
        SceneManager.LoadScene(1);
    }
    public void Exit () {
        Application.Quit();
    }

}
