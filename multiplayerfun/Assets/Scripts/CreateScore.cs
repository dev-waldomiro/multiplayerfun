using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScore : MonoBehaviour
{
    public int score1;
    public int score2;

    void Awake()
    {
        CreateRndScore();
    }

    void Update()
    {
        
    }

    void CreateRndScore ()
    {
        int rdnum =  Random.Range(3, 6);
        int adv = Random.Range(1, 3);
        switch (adv)
        {
            case 1:
                score1 = rdnum;
                score2 = rdnum - 2;
                break;
            case 2:
                score1 = rdnum - 2;
                score2 = rdnum;
                break;
        }
    }
}
