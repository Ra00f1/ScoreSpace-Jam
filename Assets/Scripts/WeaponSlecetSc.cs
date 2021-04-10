﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlecetSc : MonoBehaviour
{
    public Transform WeaponSpwanPoint;

    public GameObject Pistol;
    public GameObject Uzi;
    public GameObject SMG;
    public GameObject LMG;
    public GameObject Shotgun;
    public GameObject AutoShotgun;
    public GameObject SemiAutoShotgun;

    public GameObject CurrentWeapon;

    void Start()
    {
    }

    void Update()
    {
        CurrentWeapon = GameObject.FindGameObjectWithTag("Weapon");
        //Pistol
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(CurrentWeapon);
            if (CurrentWeapon == null)
            {
                CurrentWeapon = Instantiate(Pistol, WeaponSpwanPoint.position, Quaternion.identity);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Pistol";
            }
            else
            {
                CurrentWeapon = Instantiate(Pistol, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Pistol";
            }
        }
        //Uzi
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(CurrentWeapon);
            if (CurrentWeapon == null)
            {
                CurrentWeapon = Instantiate(Uzi, WeaponSpwanPoint.position, Quaternion.identity);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Uzi";
            }
            else
            {
                CurrentWeapon = Instantiate(Uzi, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
                CurrentWeapon.transform.SetParent(gameObject.transform);
                CurrentWeapon.gameObject.name = "Uzi";
            }
            //Shotgun
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Destroy(CurrentWeapon);
                if (CurrentWeapon == null)
                {
                    CurrentWeapon = Instantiate(Shotgun, WeaponSpwanPoint.position, Quaternion.identity);
                    CurrentWeapon.transform.SetParent(gameObject.transform);
                    CurrentWeapon.gameObject.name = "Shotgun";
                }
                else
                {
                    CurrentWeapon = Instantiate(Shotgun, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
                    CurrentWeapon.transform.SetParent(gameObject.transform);
                    CurrentWeapon.gameObject.name = "Shotgun";
                }
            }

            CurrentWeapon.transform.SetParent(gameObject.transform);

            if (CurrentWeapon != null)
            {
                CurrentWeapon.transform.SetParent(gameObject.transform);
            }
        }
    }
}
