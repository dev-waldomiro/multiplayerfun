using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameManager gameManager;
    public float speed = 20f;
    [HideInInspector] public float damage;
    Rigidbody2D rb;
    [HideInInspector] public Vector3 transformDirection;
    public float timeForDespawn = 4f;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transformDirection * speed;
    }
    
    void Update()
    {
        StartCoroutine(DestroyByTime());
    }

    IEnumerator DestroyByTime () 
    {
        //Debug.Log("Not killed yet");
        yield return new WaitForSeconds(timeForDespawn);
        Destroy(this.gameObject);
    }
}

