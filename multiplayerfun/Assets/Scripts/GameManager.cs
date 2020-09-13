using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public float player1health = 100f;
    [HideInInspector] public float player2health = 100f;
    [HideInInspector] public float player1damage = 10f;
    [HideInInspector] public float player2damage = 10f;

    public GameObject Spawn1, Spawn2;
    GameObject Player1;
    GameObject Player2;
    TimerScript timerScript;
    CreateScore createScore;
    UIManager uIManager;
    public TargetPlayers targetPlayers;

    
    void Awake()
    {
        GetPlayer(1);
        GetPlayer(2);
        timerScript = GetComponent<TimerScript>();
        createScore = GetComponent<CreateScore>();
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        targetPlayers = GameObject.Find("Main Camera").GetComponent<TargetPlayers>();
        targetPlayers.AddTargets(Player1);
        targetPlayers.AddTargets(Player2);
        Time.timeScale = 1f;
    }

    
    void Update()
    {
        if (player1health <= 0)
        {
            Spawn1.GetComponent<SpawnController>().Respawn();
            Player1.GetComponent<PlayerDamage>().health = 100f;
            player1damage = 10f;
            createScore.score2++;
        }

        if (player2health <= 0)
        {
            Player2.GetComponent<PlayerDamage>().health = 100f;
            player2damage = 10f;
            Spawn2.GetComponent<SpawnController>().Respawn();
            Debug.Log("im here");
            //Player2.GetComponent<Rigidbody2D>().position = new Vector2(Spawn2.transform.position.x, Spawn2.transform.position.y);
            createScore.score1++;
        }

        Player1.GetComponent<BulletSpawn>().bulletDamage = player1damage;
        player1health = Player1.GetComponent<PlayerDamage>().health;
        if (Player1.GetComponent<PowerUP>().powerUp) PlusDamage(1);
        if(Input.GetKeyDown(KeyCode.E))
        {
            player1damage = 10f;
        }

        Player2.GetComponent<BulletSpawn>().bulletDamage = player2damage;
        player2health = Player2.GetComponent<PlayerDamage>().health;
        if (Player2.GetComponent<PowerUP>().powerUp) PlusDamage(2);
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            player2damage = 10f;
        }

        
        if(timerScript.currentTime <= 0f)
        {
            EndGame();
        }
    }
    
    public void PlusDamage (int player)
    {
        switch (player) 
        {
            case 1: 
                player1damage += 10f;
                break;
            case 2:
                player2damage += 10f;
                break;
        }
    }

    void EndGame () 
    {
        if (createScore.score1 > createScore.score2)
        {
            uIManager.WinCondition(1);
        }
        else if (createScore.score1 == createScore.score2)
        {
            uIManager.WinCondition(2);
        }
        else if ((createScore.score1 < createScore.score2))
        {
            uIManager.WinCondition(3);
        }
        Debug.Log("ya lost son");
    }

    void GetPlayer (int player)
    {
        if(player == 1)
            Player1 = Spawn1.GetComponent<SpawnController>().playerCharacter;
        else
            Player2 = Spawn2.GetComponent<SpawnController>().playerCharacter;
    }
}
