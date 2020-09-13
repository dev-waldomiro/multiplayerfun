using System.Collections;
using System.Collections.Generic;
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
    
    void Awake()
    {
        Player1 = Spawn1.GetComponent<SpawnController>().playerCharacter;
        Player2 = Spawn2.GetComponent<SpawnController>().playerCharacter;
    }

    
    void Update()
    {
        Player1.GetComponent<BulletSpawn>().bulletDamage = player1damage;
        player1health = Player1.GetComponent<PlayerDamage>().health;
        if (Player1.GetComponent<PowerUP>().powerUp) PlusDamage(1);
        if(Input.GetKeyDown(KeyCode.E))
        {
            player1damage = 10f;
        }

        Player2.GetComponent<BulletSpawn>().bulletDamage = player2damage;
        player2health = Player2.GetComponent<PlayerDamage>().health;
        if (Player2.GetComponent<PowerUP>().powerUp) PlusDamage(1);
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            player2damage = 10f;
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


}
