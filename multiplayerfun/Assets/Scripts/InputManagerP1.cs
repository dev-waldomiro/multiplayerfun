using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerP1 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.D) && !Input.GetKeyDown(KeyCode.E))
        {
            //LOOK UP
            bulletSide = 0;
        }

        if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            pm.Movement(1);
            if (!rightSide && Input.GetKeyDown(KeyCode.D))
            {
                rightSide = !rightSide;
                fc.Flip();
            }
            bulletSide = 1;
            //walking animation
        }

        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
        {
            //LOOK DIAGONALr
            //SHOOT DIAGONALr
        }

        if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            pm.Movement(-1);
            if(rightSide && Input.GetKeyDown(KeyCode.A))
            {
                rightSide = !rightSide;
                fc.Flip();
            }
            bulletSide = 1;
            //walking animation
        }

        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
        {
            //LOOK DIAGONALl
            //SHOOT DIAGONALl
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            pj.Jump();
            //jump animation
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            bs.Shoot(bulletSide);
            //shooting animation
        }
    }
}
