using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    
    [HideInInspector] public bool hasBeenHit;
    [HideInInspector] public  float health = 100f;
    void Start()
    {
        hasBeenHit = false;
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("lol i hit it");
        if (other.gameObject.tag == "bullet") 
        {
            
            health -= other.gameObject.GetComponent<BulletScript>().damage;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "bullet")
        {
            hasBeenHit = false;
        }
    }
}
