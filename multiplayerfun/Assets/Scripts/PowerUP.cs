using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    [HideInInspector] public bool powerUp;
    public int whatPlayerIsThis;
    void Start()
    {
        powerUp = false;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "powerup")
        {
            GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            gm.PlusDamage(whatPlayerIsThis);
            Destroy(other.gameObject);
        }
    }

}
