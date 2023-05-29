using UnityEngine;

public class TimeSubtractor : MonoBehaviour
{
    public TimerScript timerScript;

    public void SubtractTime()
    {
       timerScript.SubtractTime();
    }
}