using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI p1Stats;
    public TextMeshProUGUI p2Stats;
    public GameObject endPanel;
    public TextMeshProUGUI winnerText;
    GameManager gameManager;
    CreateScore createScore;
    TimerScript timerScript;
     
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        createScore = GameObject.Find("GameManager").GetComponent<CreateScore>();
        timerScript = GameObject.Find("GameManager").GetComponent<TimerScript>();
    }

    
    void Update()
    {
        score.SetText(createScore.score1.ToString() + " x " + createScore.score2.ToString());
        timer.SetText(timerScript.currentTime.ToString("0"));
        p1Stats.SetText("Health: " + gameManager.player1health.ToString() + "\nDamage: " + gameManager.player1damage.ToString());
        p2Stats.SetText("Health: " + gameManager.player2health.ToString() + "\nDamage: " + gameManager.player2damage.ToString());
    }

    public void WinCondition (int winner)
    {
        Time.timeScale = 0f;
        endPanel.SetActive(true);

        switch (winner)
        {
            case 1:
                winnerText.SetText ("Player 1 wins!");
                break;
            case 2:
                winnerText.SetText ("IT'S A DRAW!");
                break;
            case 3:
                winnerText.SetText ("Player 2 wins!");
                break;
        }
    }
}
