using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSc : MonoBehaviour
{
    public GameObject Bullet;

    public Transform BulletSpawnPoint;

    public float UziShootingInterval = 0.3f;

    void Update()
    {
        if (gameObject.name == "Pistol(Clone)")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(Bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            }
        }
        if (gameObject.name == "Uzi(Clone)")
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (UziShootingInterval <= 0)
                {
                    Instantiate(Bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                    Debug.Log("Uzi B");
                    UziShootingInterval = 0.3f;
                }
                UziShootingInterval -= Time.time;
            }
        }
    }
}
