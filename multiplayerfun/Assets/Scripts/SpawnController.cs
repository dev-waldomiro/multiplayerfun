using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public string whatPlayerToFind;
    [HideInInspector] public GameObject playerCharacter;
    public GameObject playerToSpawn;
    

    private void Awake() 
    {
        SpawnPlayer();
    }

    public void SpawnPlayer () 
    {
        Instantiate(playerToSpawn, this.gameObject.transform.position, this.gameObject.transform.rotation);
        playerCharacter = GameObject.FindGameObjectWithTag(whatPlayerToFind);
    }

}
