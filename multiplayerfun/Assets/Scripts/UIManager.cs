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
    GameManager gameManager;
     
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
        //score.SetText();
        //timer.SetText();
        p1Stats.SetText("Health: " + gameManager.player1health.ToString() + "\nDamage: " + gameManager.player1damage.ToString());
        p2Stats.SetText("Health: " + gameManager.player2health.ToString() + "\nDamage: " + gameManager.player2damage.ToString());
    }
}
