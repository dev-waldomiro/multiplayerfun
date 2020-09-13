using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void Movement (int side)
    {
        this.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
