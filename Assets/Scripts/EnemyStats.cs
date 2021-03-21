using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public EnemyChaseSc EnemyChaseSc;

    public int Health;

    public bool Shielded;

    public int ShieldCount;

    public float Speed;

    public GameObject ShieldGO;

    public Slider HealthBar;

    public ParticleSystem PS;

    void Start()
    {
        EnemyChaseSc = gameObject.GetComponent<EnemyChaseSc>();
        EnemyChaseSc.moveSpeed = Speed;
        HealthBar.maxValue = Health;
        HealthBar.value = Health;
        ShieldGO.active = false;
        Shielded = false;

        if (ShieldCount > 0)
        {
            Shielded = true;
        }
        if (Shielded == true)
        {
            ShieldGO.active = true;
        }
    }

    public void GetDamage(int DamageAmount)
    {
        if (Shielded == true)
        {
            ShieldCount--;
            if (ShieldCount <= 0)
            {
                Shielded = false;
            }
        }
        if (Shielded == false)
        {
            Health = Health - DamageAmount;
            HealthBar.value = Health;
            if (Health <= 0)
            {
                Death();
            }
        }
    }

    public void Death()
    {
        ParticleSystem PSTemp = Instantiate(PS, gameObject.transform.position, Quaternion.identity);
        PSTemp.Play();
        Destroy(gameObject);
        Destroy(gameObject.transform.parent.gameObject);
    }
}
