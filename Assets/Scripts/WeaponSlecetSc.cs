using System.Collections;
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

    private GameObject CurrentWeapon;
    void Start()
    {

    }

    void Update()
    {
        CurrentWeapon = GameObject.FindGameObjectWithTag("Weapon");
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(CurrentWeapon);
            if (CurrentWeapon == null)
            {
                Instantiate(Pistol, WeaponSpwanPoint.position, Quaternion.identity);
            }
            else
            {
                Instantiate(Pistol, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(CurrentWeapon);
            if (CurrentWeapon == null)
            {
                Instantiate(Uzi, WeaponSpwanPoint.position, Quaternion.identity);
            }
            else
            {
                Instantiate(Uzi, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
            }


            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Destroy(CurrentWeapon);
                if (CurrentWeapon == null)
                {
                    Instantiate(Shotgun, WeaponSpwanPoint.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(Shotgun, WeaponSpwanPoint.position, WeaponSpwanPoint.rotation);
                }
            }
            if (CurrentWeapon != null)
            {
                CurrentWeapon.transform.SetParent(gameObject.transform);
            }
        }
    }
}
