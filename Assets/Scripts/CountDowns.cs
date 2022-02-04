using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDowns : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject CarControls;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public AudioSource bgAudio;
    public GameObject LapTimer;

           RawImage ImageSrc;
    public Texture img3;
    public Texture img2;
    public Texture img1;
    public Texture imgo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }
    IEnumerator CountStart (){
        LapTimer.SetActive(false);
        ImageSrc = CountDown.GetComponent<RawImage>();
        //Number 3 Countdown animation
        yield return new WaitForSeconds(0.5f);
        ImageSrc.texture = img3; //change the source
        GetReady.Play();
        CountDown.SetActive(true);//the animation will begin
        //Number 2 Countdown animation
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false); //stop the animation to change the image source
        ImageSrc.texture = img2;
        GetReady.Play();
        CountDown.SetActive(true); //the animation will begin
        //Number 1 Countdown animation
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        ImageSrc.texture = img1;
        GetReady.Play();
        CountDown.SetActive(true);
        //Ready to go Animation and Sound
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        ImageSrc.texture = imgo;
        GoAudio.Play();
        CountDown.SetActive(true);
        LapTimer.SetActive(true); //laptimer must begin the count
        CarControls.SetActive(true);//Car must be active when countdown finish
        bgAudio.Play();
    }

}
