using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HintSystem : MonoBehaviour
{
    public Text timerText;
    public float[] timeSubtractions = { 45f, 60f, 90f, 200f };
    private int currentHintIndex = 0;
    private float initialTime = 1800f;
    private float currentTime;
    private bool timerRunning = true;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
        StartCoroutine(StartTimer());
    }

    void OnButtonClick()
    {
        if (timerRunning)
        {
            float timeSubtraction = timeSubtractions[currentHintIndex];
            currentTime -= timeSubtraction;

            if (currentTime < 0)
                currentTime = 0;

            timerText.text = currentTime.ToString();

            currentHintIndex++;
            if (currentHintIndex >= timeSubtractions.Length)
                currentHintIndex = 0;
        }
    }

    IEnumerator StartTimer()
    {
        currentTime = initialTime;

        while (currentTime > 0 && timerRunning)
        {
            currentTime -= Time.deltaTime;
            timerText.text = currentTime.ToString();
            yield return null;
        }

        // Handle timer expiration here
    }
}
