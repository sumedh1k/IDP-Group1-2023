using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnComplete : MonoBehaviour
{
    //public Text Timer;
    //private float realTime;
    //private float floatTime;

    public void takeTime()
    {
        //realTime = float.Parse(Timer.text);
        PlayerPrefs.SetFloat("Room1Time", PlayerPrefs.GetFloat("Time", 100));
    }
}
