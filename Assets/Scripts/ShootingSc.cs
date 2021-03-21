using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSc : MonoBehaviour
{
    public GameObject Bullet;

    public Transform BulletSpawnPoint;

    public float UziShootingInterval = 0.2f;

    public int DamageTemp;

    void Update()
    {
        if (gameObject.name == "Pistol(Clone)")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject BulletClone =  Instantiate(Bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                DamageTemp = 10;
                BulletClone.GetComponent<BulletSc>().Damage = DamageTemp;
            }
        }
        if (gameObject.name == "Uzi(Clone)")
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                UziShootingInterval -= Time.deltaTime;
                if (UziShootingInterval <= 0)
                {
                    GameObject BulletClone = Instantiate(Bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                    UziShootingInterval = 0.2f;
                    DamageTemp = 5;
                    BulletClone.GetComponent<BulletSc>().Damage = DamageTemp;
                }
            }
        }
    }
}
