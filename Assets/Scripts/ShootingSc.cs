using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSc : MonoBehaviour
{
    public ReloadSc ReloadSc;

    public GameObject Bullet;

    public Transform BulletSpawnPoint;

    public float UziShootingInterval = 0.2f;

    public int DamageTemp;

    void Start()
    {
        ReloadSc = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<ReloadSc>();
    }

    void Update()
    {
        if (gameObject.name == "Pistol")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (ReloadSc.ClipEmpty == false)
                {
                    GameObject BulletClone = Instantiate(Bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                    DamageTemp = 10;
                    BulletClone.GetComponent<BulletSc>().Damage = DamageTemp;
                    ReloadSc.CurrentBulletC--;
                }
            }
        }
        if (gameObject.name == "Uzi")
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (ReloadSc.ClipEmpty == false)
                {
                    UziShootingInterval -= Time.deltaTime;
                    if (UziShootingInterval <= 0)
                    {
                        GameObject BulletClone = Instantiate(Bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                        UziShootingInterval = 0.2f;
                        DamageTemp = 5;
                        BulletClone.GetComponent<BulletSc>().Damage = DamageTemp;
                        ReloadSc.CurrentBulletC--;
                    }
                }
            }
        }
    }
}
