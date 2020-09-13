using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Flip ()
    {
        transform.Rotate(0f,180f,0f);
    }
}
