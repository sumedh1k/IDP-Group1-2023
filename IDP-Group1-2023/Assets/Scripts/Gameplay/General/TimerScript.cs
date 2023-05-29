using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    private float countdownTime = 30 * 60; // 30 minutes in seconds

    private void Start()
    {
        UpdateTimerText();
    }

    private void Update()
    {
        if (countdownTime > 0)
        {
            countdownTime -= Time.deltaTime;
            UpdateTimerText();
        }
    }

    public void SubtractTime()
    {
        countdownTime -= 90; // Subtract 90 seconds
        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(countdownTime / 60);
        int seconds = Mathf.FloorToInt(countdownTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
