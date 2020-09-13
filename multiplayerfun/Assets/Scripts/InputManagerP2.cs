using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerP2 : MonoBehaviour
{
    PlayerMovement pm;
    FlipCharacter fc;
    PlayerJump pj;
    BulletSpawn bs;
    private bool rightSide = true;
    private int bulletSide;

    void Start()
    {
        pm = GetComponent<PlayerMovement>();
        fc = GetComponent<FlipCharacter>();
        pj = GetComponent<PlayerJump>();
        bs = GetComponent<BulletSpawn>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !Input.GetKeyDown(KeyCode.RightArrow) && !Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //LOOK UP
            bulletSide = 0;
        }

        if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            pm.Movement(1);
            if (!rightSide && Input.GetKeyDown(KeyCode.RightArrow))
            {
                rightSide = !rightSide;
                fc.Flip();
            }
            bulletSide = 1;
            //walking animation
        }

        if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            pm.Movement(-1);
            if(rightSide && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rightSide = !rightSide;
                fc.Flip();
            }
            bulletSide = 1;
            //walking animation
        }

        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            pj.Jump();
            //jump animation
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            bs.Shoot(bulletSide);
            //shooting animation
        }
    }
}
