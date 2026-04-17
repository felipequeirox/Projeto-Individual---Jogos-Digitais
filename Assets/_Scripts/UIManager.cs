using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject loseEnemyPanel;
    public GameObject loseTimePanel;
    public TMP_Text timerDisplay;
    public TMP_Text tempoFinalText;
    public TMP_Text moedasText;

    public GameObject primeirobotaoLose;
    public GameObject primeirobotaoWin;

    private bool gameOverHandled = false;

    void FixedUpdate()
    {
        if (timerDisplay != null)
            timerDisplay.text = GameController.timeRemaining.ToString("F1") + "s";

        if (moedasText != null)
            moedasText.text = "Moedas: " + GameController.moedasPegas + "/4";

        if (!GameController.gameOver || gameOverHandled) return;

        gameOverHandled = true;

        if (GameController.isDead && loseEnemyPanel != null)
        {
            loseEnemyPanel.SetActive(true);
            EventSystem.current.SetSelectedGameObject(primeirobotaoLose);
        }

        if (GameController.isTimeUp && loseTimePanel != null)
        {
            loseTimePanel.SetActive(true);
            EventSystem.current.SetSelectedGameObject(primeirobotaoLose);
        }

        if (GameController.gameWon && winPanel != null)
        {
            winPanel.SetActive(true);
            if (tempoFinalText != null)
                tempoFinalText.text = "Finalizado em " + GameController.tempoFinal.ToString("F1") + "s";
            EventSystem.current.SetSelectedGameObject(primeirobotaoWin);
        }
    }
}