using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasWon) return;

        if (other.CompareTag("Player"))
        {
            hasWon = true;

            // Find Timer on Player
            Timer timer = other.GetComponent<Timer>();
            if (timer != null)
            {
                timer.StopTimer();

                // Change text appearance
                if (timer.timerText != null)
                {
                    timer.timerText.fontSize = 60;
                    timer.timerText.color = Color.green;
                }
            }

            Debug.Log("WIN! Time: " + timer.timerText.text);
            // Optional: GameManager.instance.WinGame();
        }
    }
}