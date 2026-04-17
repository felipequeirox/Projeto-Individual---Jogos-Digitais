using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TMP_Text timerText;

    void Update()
    {
        if (GameController.gameOver) return;

        GameController.timeRemaining -= Time.deltaTime;

        if (GameController.timeRemaining <= 0)
        {
            GameController.timeRemaining = 0;
            GameController.TimeUp();
        }

        if (timerText != null)
        {
            timerText.text = Mathf.Ceil(
                GameController.timeRemaining).ToString() + "s";
        }
    }
}