using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text timerText; 
    private float elapsedTime = 0f;
    private bool isRunning = false;

    void Update()
    {
        if (!isRunning) return;

        elapsedTime += Time.deltaTime;
        int minutes = (int)(elapsedTime / 60f);
        float seconds = elapsedTime % 60f;
        timerText.text = string.Format("{0}:{1:00.00}", minutes, seconds);
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    // Don't reset on fall
    public float GetTime() { return elapsedTime; }
}