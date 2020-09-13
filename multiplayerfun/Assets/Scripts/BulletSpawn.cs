using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public Transform firePointUp;
    public Transform firePointSide;
    public GameObject bulletPrefab;

    [HideInInspector] public float bulletDamage = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Shoot (int firePointer)
    {
        if(firePointer == 0)
        {
            bulletPrefab.GetComponent<BulletScript>().transformDirection = transform.up;
            bulletPrefab.GetComponent<BulletScript>().damage = bulletDamage;
            Instantiate(bulletPrefab, firePointUp.position, firePointUp.rotation);
        } else {
            bulletPrefab.GetComponent<BulletScript>().transformDirection = transform.right;
            bulletPrefab.GetComponent<BulletScript>().damage = bulletDamage;
            Instantiate(bulletPrefab, firePointSide.position, firePointSide.rotation);
        }
    }
}
